
namespace Face_Recognition_App
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.picDectectado = new System.Windows.Forms.PictureBox();
            this.btnEntrenar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnDectetar = new System.Windows.Forms.Button();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Login = new System.Windows.Forms.ToolStripMenuItem();
            this.Ayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.picCapturar = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDectectado)).BeginInit();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCapturar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(805, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 728);
            this.panel2.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.Controls.Add(this.btnGuardar);
            this.panel4.Controls.Add(this.picDectectado);
            this.panel4.Controls.Add(this.btnEntrenar);
            this.panel4.Controls.Add(this.btnAgregar);
            this.panel4.Controls.Add(this.txtNombre);
            this.panel4.Controls.Add(this.btnDectetar);
            this.panel4.Controls.Add(this.btnCapturar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 109);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(30, 31, 30, 31);
            this.panel4.Size = new System.Drawing.Size(339, 619);
            this.panel4.TabIndex = 23;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightGray;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(75, 432);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(200, 37);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.Text = "5. Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // picDectectado
            // 
            this.picDectectado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDectectado.Location = new System.Drawing.Point(75, 152);
            this.picDectectado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picDectectado.Name = "picDectectado";
            this.picDectectado.Size = new System.Drawing.Size(196, 171);
            this.picDectectado.TabIndex = 28;
            this.picDectectado.TabStop = false;
            // 
            // btnEntrenar
            // 
            this.btnEntrenar.BackColor = System.Drawing.Color.LightGray;
            this.btnEntrenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrenar.Location = new System.Drawing.Point(74, 385);
            this.btnEntrenar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEntrenar.Name = "btnEntrenar";
            this.btnEntrenar.Size = new System.Drawing.Size(201, 38);
            this.btnEntrenar.TabIndex = 26;
            this.btnEntrenar.Text = "4. Reconocer";
            this.btnEntrenar.UseVisualStyleBackColor = false;
            this.btnEntrenar.Click += new System.EventHandler(this.btnEntrenar_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightGray;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(75, 334);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(200, 42);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = "3. Agregar Persona";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(74, 112);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(194, 26);
            this.txtNombre.TabIndex = 24;
            // 
            // btnDectetar
            // 
            this.btnDectetar.BackColor = System.Drawing.Color.LightGray;
            this.btnDectetar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDectetar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDectetar.Location = new System.Drawing.Point(70, 60);
            this.btnDectetar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDectetar.Name = "btnDectetar";
            this.btnDectetar.Size = new System.Drawing.Size(202, 43);
            this.btnDectetar.TabIndex = 23;
            this.btnDectetar.Text = "2. Dectetar Rostro";
            this.btnDectetar.UseVisualStyleBackColor = false;
            this.btnDectetar.Click += new System.EventHandler(this.btnDectetar_Click);
            // 
            // btnCapturar
            // 
            this.btnCapturar.BackColor = System.Drawing.Color.LightGray;
            this.btnCapturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapturar.Location = new System.Drawing.Point(70, 9);
            this.btnCapturar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(204, 42);
            this.btnCapturar.TabIndex = 22;
            this.btnCapturar.Text = "1. Capturar";
            this.btnCapturar.UseVisualStyleBackColor = false;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 109);
            this.panel3.TabIndex = 22;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(339, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Login,
            this.Ayuda});
            this.menúToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(74, 28);
            this.menúToolStripMenuItem.Text = "Menú";
            // 
            // Login
            // 
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(270, 34);
            this.Login.Text = "Iniciar sesión";
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Ayuda
            // 
            this.Ayuda.Name = "Ayuda";
            this.Ayuda.Size = new System.Drawing.Size(270, 34);
            this.Ayuda.Text = "Ayuda";
            this.Ayuda.Click += new System.EventHandler(this.Ayuda_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.picCapturar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.panel1.Size = new System.Drawing.Size(805, 728);
            this.panel1.TabIndex = 10;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(15, 681);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(775, 32);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusLabel
            // 
            this.lblStatusLabel.Name = "lblStatusLabel";
            this.lblStatusLabel.Size = new System.Drawing.Size(101, 25);
            this.lblStatusLabel.Text = "StatusLabel";
            // 
            // picCapturar
            // 
            this.picCapturar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCapturar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCapturar.Image = ((System.Drawing.Image)(resources.GetObject("picCapturar.Image")));
            this.picCapturar.Location = new System.Drawing.Point(15, 15);
            this.picCapturar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picCapturar.Name = "picCapturar";
            this.picCapturar.Size = new System.Drawing.Size(775, 698);
            this.picCapturar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCapturar.TabIndex = 1;
            this.picCapturar.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1144, 728);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Reconocimiento Facial";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDectectado)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCapturar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox picDectectado;
        private System.Windows.Forms.Button btnEntrenar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnDectetar;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusLabel;
        private System.Windows.Forms.PictureBox picCapturar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Login;
        private System.Windows.Forms.ToolStripMenuItem Ayuda;
    }
}

