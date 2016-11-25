using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TELECOM_RTD_System_1._0
{
    public partial class frmObras : Form 
    {
        DataTable EmpleadosDT = new DataTable();
        int IdObra, R = 0;
        int IdTemp;
        int NoEmp;
        string NomEmp, ApPaterno;
        float SueldoSemanal;
        string Fecha_Inicio, Fecha_Final;
        string PEP, NomObra, RBS;        
        int User;
        string Usuario;

        public frmObras()
        {
        }
        
        public frmObras(int User, string Usuario)
        {
            InitializeComponent();
            this.User = User;
            this.Usuario = Usuario;
        }



        private void frmModeloObras_Load(object sender, EventArgs e)
        {
            Conexiones conexcion = new Conexiones();
            DataTable DT = new DataTable();
            DT = conexcion.MostrarObras();
            dataGridView1.DataSource = DT;
            dataGridView1.Columns.Add("Auto", "NoAuto");

            dataGridView2.Columns.Add("idObra", "No.Obra");
            dataGridView2.Columns.Add("idEmpleado","No.Empleado");
            dataGridView2.Columns.Add("NomEmp", "Nombre");
            dataGridView2.Columns.Add("ApPaterno", "Paterno");
            dataGridView2.Columns.Add("SueldoSem", "Sueldo");

            dataGridView3.Columns.Add("idObras", "No.Obra");
            dataGridView3.Columns.Add("Descripcion", "Descripcion");

            Conexiones Conexion = new Conexiones();
            comboBox1.DataSource = Conexion.Autos();
            comboBox1.DisplayMember = "Descripcion";
            comboBox1.Enabled = false;
            IdObrastxt.Focus();
            usertxt.Text = Usuario;
        }

        

        private void Cancelarbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Fecha_Inicio = FecIniDTP.Value.Date.ToShortDateString();
            
        }

        private void Guardarbtn_Click(object sender, EventArgs e)
        {            
                Conexiones Conexion = new Conexiones();
                
                NomObra = NomObrtxt.Text;
                PEP = PEPtxt.Text;
                NomObra = NomObrtxt.Text;
                Fecha_Inicio = FecIniDTP.Value.ToShortDateString();
                Fecha_Final = FecTerDTP.Value.ToShortDateString();
                RBS = RBStxt.Text;
                Nuevobtn.Enabled = true;
                BorrarObbtn.Enabled = true;


                Conexion.InsertarObra(PEP, NomObra, RBS, User);
                //this.obrasTableAdapter.Fill(this.telecomRTD_DBDataSet.Obras);   eliminar
                Conexion.AltaAvance(Fecha_Inicio, Fecha_Final, Convert.ToInt32(IdObrastxt.Text), "0");

                int i = 0;
                List<string> Descripciones = new List<string>();
                foreach (DataGridViewRow row in dataGridView3.Rows)
                {
                    string Desc = row.Cells["Descripcion"].Value.ToString();
                    Descripciones.Add(Desc);
                }
                string[] Autos = Descripciones.ToArray();
                while (i < Autos.Length)
                {
                    Conexion.AltaObraAutos(Convert.ToInt32(IdObrastxt.Text), Autos[i]);
                    i++;
                }
                i = 0;
                List<int> idEmp = new List<int>();
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    int id = Int32.Parse(row.Cells["idEmpleado"].Value.ToString());
                    idEmp.Add(id);
                }
                int[] idEmpleados = idEmp.ToArray();
                while (i < idEmpleados.Length)
                {
                    Conexion.AgregarObraEmpleado(Convert.ToInt32(IdObrastxt.Text), idEmpleados[i]);
                    i++;
                }
                DataTable DT = new DataTable();
                DT = Conexion.MostrarObras();
                dataGridView1.DataSource = DT;

                Avancesbtn.Enabled = true;
            
        }

        private void Nuevobtn_Click(object sender, EventArgs e)
        {
            int countRows = dataGridView1.Rows.Count - 1;
            if (countRows == -1)
            {
                IdObrastxt.Text = "1";
            }
            else
            {
                int valorCelda = Convert.ToInt32(dataGridView1.Rows[countRows].Cells[0].Value.ToString()) + 1;
                IdObrastxt.Text = Convert.ToString(valorCelda);
            }
            Nuevobtn.Enabled = false;
            PEPtxt.Enabled = true;
            NomObrtxt.Enabled = true;
            FecIniDTP.Enabled = true;
            FecTerDTP.Enabled = true;            
            RBStxt.Enabled = true;
            Limpiarbtn.Enabled = true;
            Avancesbtn.Enabled = false;
            Guardarbtn.Enabled = true;
            BorrarObbtn.Enabled = false;
            Trabtxt.Enabled = true;
            Buscarbtn.Enabled = true;
            comboBox1.Enabled = true;
            AgregarAutobtn.Enabled = true;
        }

        private void Limpiarbtn_Click(object sender, EventArgs e)
        {
            PEPtxt.Clear();
            NomObrtxt.Clear();
            FecIniDTP.Value = DateTime.Today;
            FecTerDTP.Value = DateTime.Today;
            RBStxt.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAgreTrab Trab = new frmAgreTrab();
            Trab.ShowDialog();
            Trabtxt.Text = Trab.Trabajador;
            NoEmp = Trab.NoEmpleado;
            NomEmp = Trab.Nombre;
            ApPaterno = Trab.Paterno;
            SueldoSemanal = Trab.Sueldo;
            Agregarbtn.Enabled = true;
        }

        public void Agregarbtn_Click(object sender, EventArgs e)
        {

            dataGridView2.Rows.Add(IdObrastxt.Text, NoEmp, NomEmp, ApPaterno, (SueldoSemanal * 7));         
            int result = dataGridView2.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToInt32(x.Cells["SueldoSem"].Value));
            TSueltxt.Text = result.ToString();
        }

        private void BorrarObbtn_Click(object sender, EventArgs e)
        {            
            Conexiones Conexion = new Conexiones();
            Conexion.BajaAutoObra(IdTemp);
            Conexion.EliminarAvance(IdTemp);
            Conexion.EliminarObra(IdTemp);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           IdTemp = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void Avancesbtn_Click(object sender, EventArgs e)
        {
            frmAvances Avances = new frmAvances();
            Avances.ShowDialog();
        }


        private void AgregarAutobtn_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Add(IdObrastxt.Text, comboBox1.Text);
        }

        private void IdObrastxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void PEPtxt_Validating(object sender, CancelEventArgs e)
        {
            if (PEPtxt.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(PEPtxt, "Introdusca el PEP");
            }
            else
            {
                errorProvider1.SetError(PEPtxt, null);
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.obrasTableAdapter.FillBy(this.telecomRTD_DBDataSet.Obras);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.obrasTableAdapter.FillBy(this.telecomRTD_DBDataSet.Obras);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void NomObrtxt_Validating(object sender, CancelEventArgs e)
        {
            if (NomObrtxt.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(NomObrtxt, "Introdusca el Nombre");
            }
            else
            {
                errorProvider1.SetError(NomObrtxt, null);
            }
        }

        private void RBStxt_Validating(object sender, CancelEventArgs e)
        {
            if (RBStxt.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(RBStxt, "Introdusca el RBS");
            }
            else
            {
                errorProvider1.SetError(NomObrtxt, null);
            }
        }


    }
}
