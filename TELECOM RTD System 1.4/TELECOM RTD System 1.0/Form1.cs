using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TELECOM_RTD_System_1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Aceptar_btn_Click(object sender, EventArgs e)
        {
            if (User_txt.Text.Length != 0)
            {
                string Usuario = User_txt.Text;
                string Password = Password_txt.Text;
                bool Log = false;                
                if (Password_txt.Text.Length != 0)
                {
                    Conexiones Conexion = new Conexiones();
                    Log = Conexion.Login(Usuario, Password);
                    if (Log == true)
                    {
                        //usuario anterior administrador rh
                        if (Usuario == "raul")
                        {
                            this.Hide();
                            User_txt.Clear();
                            Password_txt.Clear();
                            frmMenuRH M = new frmMenuRH(1, Usuario);
                            M.Show();
                        }
                        else
                        {

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Introdusca su contraseña!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }    
            }
            else
            {
                MessageBox.Show("Introdusca su usuario!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Password_txt.PasswordChar = '*';
            Password_txt.MaxLength = 15;
        }

        private void Salir_btn_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void User_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
