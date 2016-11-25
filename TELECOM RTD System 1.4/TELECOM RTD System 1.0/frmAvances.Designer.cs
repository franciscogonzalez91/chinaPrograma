namespace TELECOM_RTD_System_1._0
{
    partial class frmAvances
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAvances));
            this.telecomRTD_DBDataSet = new TELECOM_RTD_System_1._0.TelecomRTD_DBDataSet();
            this.avancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avancesTableAdapter = new TELECOM_RTD_System_1._0.TelecomRTD_DBDataSetTableAdapters.AvancesTableAdapter();
            this.tableAdapterManager = new TELECOM_RTD_System_1._0.TelecomRTD_DBDataSetTableAdapters.TableAdapterManager();
            this.avancesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.avancesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.avancesDataGridView = new System.Windows.Forms.DataGridView();
            this.Aceptarbtn = new System.Windows.Forms.Button();
            this.Modificarbtn = new System.Windows.Forms.Button();
            this.Cancelarbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtidObras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.telecomRTD_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avancesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avancesBindingNavigator)).BeginInit();
            this.avancesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avancesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // telecomRTD_DBDataSet
            // 
            this.telecomRTD_DBDataSet.DataSetName = "TelecomRTD_DBDataSet";
            this.telecomRTD_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // avancesBindingSource
            // 
            this.avancesBindingSource.DataMember = "Avances";
            this.avancesBindingSource.DataSource = this.telecomRTD_DBDataSet;
            // 
            // avancesTableAdapter
            // 
            this.avancesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AcreedoresTableAdapter = null;
            this.tableAdapterManager.AsistenciaTableAdapter = null;
            this.tableAdapterManager.AutosTableAdapter = null;
            this.tableAdapterManager.AvancesTableAdapter = this.avancesTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.GastosTableAdapter = null;
            this.tableAdapterManager.IngresosTableAdapter = null;
            this.tableAdapterManager.InventarioTableAdapter = null;
            this.tableAdapterManager.LoginsTableAdapter = null;
            this.tableAdapterManager.NominasTableAdapter = null;
            this.tableAdapterManager.ObrasTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TELECOM_RTD_System_1._0.TelecomRTD_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // avancesBindingNavigator
            // 
            this.avancesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.avancesBindingNavigator.BindingSource = this.avancesBindingSource;
            this.avancesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.avancesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.avancesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.avancesBindingNavigatorSaveItem});
            this.avancesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.avancesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.avancesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.avancesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.avancesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.avancesBindingNavigator.Name = "avancesBindingNavigator";
            this.avancesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.avancesBindingNavigator.Size = new System.Drawing.Size(380, 25);
            this.avancesBindingNavigator.TabIndex = 0;
            this.avancesBindingNavigator.Text = "bindingNavigator1";
            this.avancesBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // avancesBindingNavigatorSaveItem
            // 
            this.avancesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.avancesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("avancesBindingNavigatorSaveItem.Image")));
            this.avancesBindingNavigatorSaveItem.Name = "avancesBindingNavigatorSaveItem";
            this.avancesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.avancesBindingNavigatorSaveItem.Text = "Guardar datos";
            this.avancesBindingNavigatorSaveItem.Click += new System.EventHandler(this.avancesBindingNavigatorSaveItem_Click);
            // 
            // avancesDataGridView
            // 
            this.avancesDataGridView.AllowUserToAddRows = false;
            this.avancesDataGridView.AllowUserToDeleteRows = false;
            this.avancesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.avancesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.avancesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtidObras,
            this.Column1,
            this.Column2,
            this.Column3});
            this.avancesDataGridView.Location = new System.Drawing.Point(16, 67);
            this.avancesDataGridView.Name = "avancesDataGridView";
            this.avancesDataGridView.ReadOnly = true;
            this.avancesDataGridView.Size = new System.Drawing.Size(366, 98);
            this.avancesDataGridView.TabIndex = 1;
            this.avancesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.avancesDataGridView_CellContentClick);
            // 
            // Aceptarbtn
            // 
            this.Aceptarbtn.Location = new System.Drawing.Point(153, 181);
            this.Aceptarbtn.Name = "Aceptarbtn";
            this.Aceptarbtn.Size = new System.Drawing.Size(71, 23);
            this.Aceptarbtn.TabIndex = 7;
            this.Aceptarbtn.Text = "Aceptar";
            this.Aceptarbtn.UseVisualStyleBackColor = true;
            this.Aceptarbtn.Click += new System.EventHandler(this.Aceptarbtn_Click);
            // 
            // Modificarbtn
            // 
            this.Modificarbtn.Location = new System.Drawing.Point(64, 181);
            this.Modificarbtn.Name = "Modificarbtn";
            this.Modificarbtn.Size = new System.Drawing.Size(71, 23);
            this.Modificarbtn.TabIndex = 6;
            this.Modificarbtn.Text = "Modificar";
            this.Modificarbtn.UseVisualStyleBackColor = true;
            // 
            // Cancelarbtn
            // 
            this.Cancelarbtn.Location = new System.Drawing.Point(243, 181);
            this.Cancelarbtn.Name = "Cancelarbtn";
            this.Cancelarbtn.Size = new System.Drawing.Size(71, 23);
            this.Cancelarbtn.TabIndex = 8;
            this.Cancelarbtn.Text = "Cancelar";
            this.Cancelarbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Porcentaje:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(276, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(30, 20);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(30, 20);
            this.textBox2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "No.Obra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "%";
            // 
            // dtidObras
            // 
            this.dtidObras.HeaderText = "idObras";
            this.dtidObras.Name = "dtidObras";
            this.dtidObras.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "FecIni";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "FecFin";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Avance";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // frmAvances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 224);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancelarbtn);
            this.Controls.Add(this.Aceptarbtn);
            this.Controls.Add(this.Modificarbtn);
            this.Controls.Add(this.avancesDataGridView);
            this.Controls.Add(this.avancesBindingNavigator);
            this.Name = "frmAvances";
            this.Text = "frmAvances";
            this.Load += new System.EventHandler(this.frmAvances_Load);
            ((System.ComponentModel.ISupportInitialize)(this.telecomRTD_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avancesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avancesBindingNavigator)).EndInit();
            this.avancesBindingNavigator.ResumeLayout(false);
            this.avancesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avancesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TelecomRTD_DBDataSet telecomRTD_DBDataSet;
        private System.Windows.Forms.BindingSource avancesBindingSource;
        private TelecomRTD_DBDataSetTableAdapters.AvancesTableAdapter avancesTableAdapter;
        private TelecomRTD_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator avancesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton avancesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView avancesDataGridView;
        private System.Windows.Forms.Button Aceptarbtn;
        private System.Windows.Forms.Button Modificarbtn;
        private System.Windows.Forms.Button Cancelarbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtidObras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}