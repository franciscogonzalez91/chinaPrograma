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
    public partial class frmEmp : Form
    {
        public frmEmp()
        {
            InitializeComponent();
        }

        private void frmEmp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEmpleados emp = new frmEmpleados();
            emp.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmMenuRH M = new frmMenuRH();
            
            M.Visible = true;

            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
