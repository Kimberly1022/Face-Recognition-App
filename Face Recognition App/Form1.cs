using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using Emgu.CV.CvEnum;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace Face_Recognition_App
{
    public partial class Form1 : Form
    {
        #region Variables
        private Capture videocapture = null;
        private Image<Bgr, Byte> currentFrame = null;
        Mat frame = new Mat();
        private bool facesDetectionEnabled = false;
        CascadeClassifier faceCasacdeClassifier = new CascadeClassifier("haarcascade_frontalface_alt.xml");
        Image<Bgr, Byte> faceResult = null;
        List<Image<Gray, Byte>> TrainedFaces = new List<Image<Gray, byte>>();
        List<int> PersonsLabes = new List<int>();
        bool EnableSaveImage = false;
        private static bool isTrained = false;
        EigenFaceRecognizer recognizer;
        List<string> PersonsNames = new List<string>();


        #endregion


        public Form1()
        {
            try
            {
                InitializeComponent();
            }
            catch (AccessViolationException Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lblStatusLabel.Text = "Desconectado";

        }
        private void AbrirFormulario(Form form)
        {
            form.FormBorderStyle = FormBorderStyle.Sizable;
            form.ShowDialog(this);
        }

        private void Login_Click(object sender, EventArgs e)
        {

            try
            {

                lblStatusLabel.Text = "Connectando...";
                Login login = new Login();
                AbrirFormulario(login);

                if (!String.IsNullOrEmpty(login.Usuario))
                {
                    Login.Enabled = false;
                    lblStatusLabel.Text = login.Usuario;
                }
                else
                {
                    lblStatusLabel.Text = "Desconectado";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha Ocurrido un error" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void Ayuda_Click(object sender, EventArgs e)
        {
            Ayuda ayuda = new Ayuda();
            AbrirFormulario(ayuda);
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            if (videocapture != null && videocapture.Ptr != IntPtr.Zero)
            {
                //Paso 1: Captura del video
                videocapture.Retrieve(frame, 0);
                currentFrame = frame.ToImage<Bgr, Byte>().Resize(picCapturar.Width, picCapturar.Height, Inter.Cubic);

                //Paso 2: Dectectar Rostro
                if (facesDetectionEnabled)
                {
                    //Convierte la imagen Bgr en una Imagen Gris
                    Mat grayImage = new Mat();
                    CvInvoke.CvtColor(currentFrame, grayImage, ColorConversion.Bgr2Gray);
                    //Mejora la imagen para obtener mejores resultados
                    CvInvoke.EqualizeHist(grayImage, grayImage);

                    Rectangle[] faces = faceCasacdeClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);

                    if (faces.Length > 0)
                    {

                        foreach (var face in faces)
                        {
                            //Dibuja un cuadrado alrededor de cada cara
                            CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Blue).MCvScalar, 2);

                            //Paso 3: Agregar Persona
                            //Asignar la cara al picture Box 
                            Image<Bgr, Byte> resultImage = currentFrame.Convert<Bgr, Byte>();
                            resultImage.ROI = face;
                            picDectectado.SizeMode = PictureBoxSizeMode.StretchImage;
                            picDectectado.Image = resultImage.Bitmap;

                            if (EnableSaveImage)
                            {
                                //Creamos un directorio si no exixte 
                                string path = Directory.GetCurrentDirectory() + @"\TrainedImages";
                                if (!Directory.Exists(path))
                                    Directory.CreateDirectory(path);

                                Task.Factory.StartNew(() =>
                                {
                                    if (txtNombre.Text != "")
                                    {
                                        for (int i = 0; i < 20; i++)
                                        {
                                            //cambiar el tamaño de la imagen y luego guardarla
                                            resultImage.Resize(200, 200, Inter.Cubic).Save(path + @"\" + txtNombre.Text + "_" + DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + ".jpg");
                                            Thread.Sleep(1000);
                                        }
                                    }
                                    MessageBox.Show("Por favor ingrese un Nombre ");

                                });

                            }
                            EnableSaveImage = false;

                            if (btnAgregar.InvokeRequired)
                            {
                                btnAgregar.Invoke(new ThreadStart(delegate
                                {
                                    btnAgregar.Enabled = true;
                                }));
                            }

                            // Paso 5: Reconocer rostro
                            if (isTrained)
                            {
                                Image<Gray, Byte> grayFaceResult = resultImage.Convert<Gray, Byte>().Resize(200, 200, Inter.Cubic);
                                CvInvoke.EqualizeHist(grayFaceResult, grayFaceResult);
                                var result = recognizer.Predict(grayFaceResult);
                                Debug.WriteLine(result.Label + ". " + result.Distance);
                                //Aquí los resultados encontraron caras conocidas
                                if (result.Label != -1 && result.Distance < 2000)
                                {
                                    CvInvoke.PutText(currentFrame, PersonsNames[result.Label], new Point(face.X - 2, face.Y - 4),
                                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                    CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Green).MCvScalar, 2);
                                }
                                //Aquí los resultados no encontraron caras conocidas
                                else
                                {
                                    CvInvoke.PutText(currentFrame, "Desconocido", new Point(face.X - 2, face.Y - 2),
                                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                    CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Red).MCvScalar, 2);

                                }
                            }

                        }
                    }
                }

                //Renderiza la captura del video en el cuadro de imagen picCapturar
                picCapturar.Image = currentFrame.Bitmap;

            }
            if (currentFrame != null)
                currentFrame.Dispose();
        }

        //Paso 4: entrenar imágenes
        private bool TrainImagesFromDir()
        {
            int ImagesCount = 0;
            double Threshold = 2000;
            TrainedFaces.Clear();
            PersonsLabes.Clear();
            PersonsNames.Clear();
            try
            {
                string path = Directory.GetCurrentDirectory() + @"\TrainedImages";
                string[] files = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories);

                foreach (var file in files)
                {
                    Image<Gray, byte> trainedImage = new Image<Gray, byte>(file).Resize(200, 200, Inter.Cubic);
                    TrainedFaces.Add(trainedImage);
                    PersonsLabes.Add(ImagesCount);
                    string name = file.Split('\\').Last().Split('_')[0];
                    PersonsNames.Add(name);
                    ImagesCount++;
                    Debug.WriteLine(ImagesCount + ". " + name);

                }

                if (TrainedFaces.Count() > 0)
                {
                    // recognizer = new EigenFaceRecognizer(ImagesCount,Threshold);
                    recognizer = new EigenFaceRecognizer(ImagesCount, Threshold);
                    recognizer.Train(TrainedFaces.ToArray(), PersonsLabes.ToArray());

                    isTrained = true;
                    //Debug.WriteLine(ImagesCount);
                    //Debug.WriteLine(isTrained);
                    return true;
                }
                else
                {
                    isTrained = false;
                    return false;
                }
            }
            catch (Exception ex)
            {
                isTrained = false;
                MessageBox.Show("Error al entrenar imagen: " + ex.Message);
                return false;
            }

        }

        /// <summary>
        /// Botones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCapturar_Click(object sender, EventArgs e)
        {
            videocapture = new Capture();
            Application.Idle += ProcessFrame;
            //videocapture.ImageGrabbed += ProcessFrame;
            //videocapture.Start();
        }

        private void btnDectetar_Click(object sender, EventArgs e)
        {
            facesDetectionEnabled = true;
        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            btnAgregar.Enabled = false;
            EnableSaveImage = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
            btnAgregar.Enabled = true;
            EnableSaveImage = false;
            picDectectado.Image = null;
            this.txtNombre.Clear();
        }
        
        private void btnEntrenar_Click_1(object sender, EventArgs e)
        {
            TrainImagesFromDir();
        }

        /// <summary>
        /// Eventos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de salir?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        
    }      
}
 


       