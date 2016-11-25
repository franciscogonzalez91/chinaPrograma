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
    public partial class frmAltaObras : Form
    {
        int IdObra, PEP, NomObra, Supervisor, Empalmador, Auxiliar, Carro, RBS;
        Obras O = new Obras();
        string Fecha_Inicio;
        public frmAltaObras()
        {
            InitializeComponent();
        }

        /*private void frmModeloObras_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = this.CreateGraphics();            
            SolidBrush SB = new SolidBrush(Color.Chocolate);
            Pen pen = new Pen(SB, 16);
            G.DrawRectangle(pen, 0, 0, 505, 447);
        }*/

        private void frmModeloObras_Load(object sender, EventArgs e)
        {
         /*   if (Fechatxt.Text == "1")
            {
                monthCalendar1.Visible = true;
            }*/
        }

        private void Fechatxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fechatxt_DoubleClick(object sender, EventArgs e)
        {
           // monthCalendar1.Visible = true;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            //Fechatxt.Text = monthCalendar1.SelectionEnd.Day.ToString() + "/" + monthCalendar1.SelectionEnd.Month.ToString() + "/" + monthCalendar1.SelectionEnd.Year.ToString(); 
            

        }

        private void frmModeloObras_Click(object sender, EventArgs e)
        {
            //monthCalendar1.Visible = false;            
        }

        private void monthCalendar1_DateSelected_1(object sender, DateRangeEventArgs e)
        {
         //   monthCalendar1.Visible = false;
        }

        private void Cancelarbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            O.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Fecha_Inicio = dateTimePicker1.Value.Date.ToShortDateString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
