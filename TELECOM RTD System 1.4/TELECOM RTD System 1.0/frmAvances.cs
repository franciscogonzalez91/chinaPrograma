using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace TELECOM_RTD_System_1._0
{
    public partial class frmAvances : Form
    {
        Conexiones con = new Conexiones();
        public frmAvances()
        {
            InitializeComponent();
        }

        private void avancesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.avancesBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.telecomRTD_DBDataSet);

        }

        private void frmAvances_Load(object sender, EventArgs e)

        // TODO: esta línea de código carga datos en la tabla 'telecomRTD_DBDataSet.Avances' Puede moverla o quitarla según sea necesario.
        //this.avancesTableAdapter.Fill(this.telecomRTD_DBDataSet.Avances);
        {
            CargarAvances();
        }
        private void CargarAvances()
        {
            DataTable avances = new DataTable();
            avances = con.MostrarAvanzes();
            foreach(DataRow dt in avances.Rows)
            {
                avancesDataGridView.Rows.Add(dt[0].ToString(), dt[1].ToString(), dt[2].ToString(), dt[3].ToString());
            }
        }

        private void avancesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Aceptarbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
