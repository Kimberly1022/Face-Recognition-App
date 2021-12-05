using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Face_Recognition_App
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public string Usuario { get; set; }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Usuario = String.Empty;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtUserName.Text))
            {
                this.Usuario = txtUserName.Text;
                this.Close();
            }
            else
                MessageBox.Show("Please insert a username", "Error validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
