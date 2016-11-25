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
    public partial class frmEmpleados : Form
    {
        int idEmpleado, Dia, Año;
        string Nombre, Paterno, Materno, Puesto, Sexo, CURP, RFC, IMSS, Tel, Direccion, Mes, DiaT;

        private void SexoCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void Guardarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                idEmpleado = Int32.Parse(idEmpleadotxt.Text);
                Nombre = Nomtxt.Text;
                Paterno = ApPattxt.Text;
                Materno = ApMattxt.Text;
                Puesto = Puestotxt.Text;
                Sexo = SexoCB.Text;
                CURP = CURPtxt.Text;
                RFC = RFCtxt.Text;
                IMSS = IMSStxt.Text;
                DiaT = DiaCB.Text;
                Dia = Int32.Parse(DiaT);
                Mes = MesCB.Text;
                Año = Int32.Parse(Añotxt.Text);
                Tel = Teltxt.Text;
                Direccion = Dirtxt.Text;
                Conexiones Emp = new Conexiones();
                Emp.InsertaEmpleado(idEmpleado, Nombre, Paterno, Materno, Sexo, CURP, RFC, IMSS, Año, Tel, Direccion, Puesto, 1561);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message, "");
            }
        }
    }
}
