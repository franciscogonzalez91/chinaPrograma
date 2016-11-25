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
    public partial class frmMenuRH : Form
    {
        
        int User;
        string Usuario;
        public frmMenuRH(int User, string Usuario)
        {
            InitializeComponent();
            this.User = User;
            this.Usuario = Usuario;
        }
        public frmMenuRH()
        {
            InitializeComponent();           
        }

        private void frmMenuP_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmMenuP_Load(object sender, EventArgs e)
        {
            Empleadosbtn.Enabled = true; /*anteriormente false todas*/
            Gastosbtn.Enabled = true;
            Almacenbtn.Enabled = true;
            UserOpbtn.Enabled = true;
            Autobtn.Enabled = true;
        }

        private void frmMenuP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Obrasbtn_Click(object sender, EventArgs e)
        {
            frmObras Obras = new frmObras(User, Usuario);
            Obras.ShowDialog();
            
        }

        private void Empleadosbtn_Click(object sender, EventArgs e)
        {
            frmEmp E = new frmEmp();
            this.Hide();
            E.ShowDialog();
        }

        private void Gastosbtn_Click(object sender, EventArgs e)
        {

        }

        private void Almacenbtn_Click(object sender, EventArgs e)
        {

        }

        private void CerSesbtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 F = new Form1();
            F.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Salirbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Inicio = new Form1();
            Inicio.Show();
        }





    }
}
