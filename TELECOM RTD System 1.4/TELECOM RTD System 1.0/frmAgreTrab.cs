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
    public partial class frmAgreTrab : Form
    {
        public string Trabajador;
        public string Nombre, Paterno;
        public float Sueldo;
        public int NoEmpleado;
        public frmAgreTrab()
        {
            InitializeComponent();
        }

        private void frmAgreTrab_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'telecomRTD_DBDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            //this.empleadosTableAdapter.Fill(this.telecomRTD_DBDataSet.Empleados);
        }

        private void Aceptarbtn_Click(object sender, EventArgs e)
        {
            Trabajador = Nombre + Paterno;
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.empleadosTableAdapter.FillByNomPues(this.telecomRTD_DBDataSet.Empleados, /*"%" + "%" + "%" + "%" +*/ "%" + TrabObtxt.Text + "%");
        }

        private void empleadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empleadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.telecomRTD_DBDataSet);

        }

        private void empleadosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.empleadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.telecomRTD_DBDataSet);

        }

        private void fillByNomPuesToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                empleadosTableAdapter.FillByNomPues(telecomRTD_DBDataSet.Empleados, "%" +cadenaToolStripTextBox.Text + "%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void empleadosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void empleadosDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            NoEmpleado = Convert.ToInt32(empleadosDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            Nombre = empleadosDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            Paterno = empleadosDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            Sueldo = Single.Parse(empleadosDataGridView.Rows[e.RowIndex].Cells[12].Value.ToString());
            TrabObtxt.Text = empleadosDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString(); ;
        }

        private void empleadosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



    }
}
