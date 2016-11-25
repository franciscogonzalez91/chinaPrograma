namespace TELECOM_RTD_System_1._0
{
    partial class frmObras
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AgregarAutobtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.autosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telecomRTD_DBDataSet = new TELECOM_RTD_System_1._0.TelecomRTD_DBDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.FecTerDTP = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.RBStxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.IdObrastxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PEPtxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.FecIniDTP = new System.Windows.Forms.DateTimePicker();
            this.NomObrtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Guardarbtn = new System.Windows.Forms.Button();
            this.Limpiarbtn = new System.Windows.Forms.Button();
            this.Cancelarbtn = new System.Windows.Forms.Button();
            this.Avancesbtn = new System.Windows.Forms.Button();
            this.BorrarObbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Nuevobtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.obrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Borrarbtn = new System.Windows.Forms.Button();
            this.Trabtxt = new System.Windows.Forms.TextBox();
            this.Agregarbtn = new System.Windows.Forms.Button();
            this.Buscarbtn = new System.Windows.Forms.Button();
            this.Trabajadores = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.telecomRTDDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TSueltxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.obrasTableAdapter = new TELECOM_RTD_System_1._0.TelecomRTD_DBDataSetTableAdapters.ObrasTableAdapter();
            this.autosTableAdapter = new TELECOM_RTD_System_1._0.TelecomRTD_DBDataSetTableAdapters.AutosTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telecomRTD_DBDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telecomRTDDBDataSetBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Maroon;
            this.groupBox1.Controls.Add(this.AgregarAutobtn);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.FecTerDTP);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.RBStxt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.IdObrastxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PEPtxt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.FecIniDTP);
            this.groupBox1.Controls.Add(this.NomObrtxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(20, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // AgregarAutobtn
            // 
            this.AgregarAutobtn.Enabled = false;
            this.AgregarAutobtn.Location = new System.Drawing.Point(323, 199);
            this.AgregarAutobtn.Name = "AgregarAutobtn";
            this.AgregarAutobtn.Size = new System.Drawing.Size(58, 23);
            this.AgregarAutobtn.TabIndex = 7;
            this.AgregarAutobtn.Text = "Agregar";
            this.AgregarAutobtn.UseVisualStyleBackColor = true;
            this.AgregarAutobtn.Click += new System.EventHandler(this.AgregarAutobtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.autosBindingSource, "Descripcion", true));
            this.comboBox1.DataSource = this.autosBindingSource;
            this.comboBox1.DisplayMember = "Descripcion";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(140, 201);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "tacoma";
            this.comboBox1.ValueMember = "Descripcion";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // autosBindingSource
            // 
            this.autosBindingSource.DataMember = "Autos";
            this.autosBindingSource.DataSource = this.telecomRTD_DBDataSet;
            // 
            // telecomRTD_DBDataSet
            // 
            this.telecomRTD_DBDataSet.DataSetName = "TelecomRTD_DBDataSet";
            this.telecomRTD_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(19, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Automovil:";
            // 
            // FecTerDTP
            // 
            this.FecTerDTP.Enabled = false;
            this.FecTerDTP.Location = new System.Drawing.Point(140, 137);
            this.FecTerDTP.Name = "FecTerDTP";
            this.FecTerDTP.Size = new System.Drawing.Size(241, 20);
            this.FecTerDTP.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(19, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Fecha de Termino:";
            // 
            // RBStxt
            // 
            this.RBStxt.Enabled = false;
            this.RBStxt.Location = new System.Drawing.Point(140, 168);
            this.RBStxt.Name = "RBStxt";
            this.RBStxt.Size = new System.Drawing.Size(241, 20);
            this.RBStxt.TabIndex = 5;
            this.RBStxt.Validating += new System.ComponentModel.CancelEventHandler(this.RBStxt_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(19, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "RBS:";
            // 
            // IdObrastxt
            // 
            this.IdObrastxt.Enabled = false;
            this.IdObrastxt.Location = new System.Drawing.Point(140, 13);
            this.IdObrastxt.Name = "IdObrastxt";
            this.IdObrastxt.Size = new System.Drawing.Size(30, 20);
            this.IdObrastxt.TabIndex = 26;
            this.IdObrastxt.TextChanged += new System.EventHandler(this.IdObrastxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(19, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "IdObras:";
            // 
            // PEPtxt
            // 
            this.PEPtxt.Enabled = false;
            this.PEPtxt.Location = new System.Drawing.Point(140, 43);
            this.PEPtxt.Name = "PEPtxt";
            this.PEPtxt.Size = new System.Drawing.Size(241, 20);
            this.PEPtxt.TabIndex = 1;
            this.PEPtxt.Validating += new System.ComponentModel.CancelEventHandler(this.PEPtxt_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(20, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "PEP:";
            // 
            // FecIniDTP
            // 
            this.FecIniDTP.Enabled = false;
            this.FecIniDTP.Location = new System.Drawing.Point(140, 105);
            this.FecIniDTP.Name = "FecIniDTP";
            this.FecIniDTP.Size = new System.Drawing.Size(241, 20);
            this.FecIniDTP.TabIndex = 4;
            this.FecIniDTP.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // NomObrtxt
            // 
            this.NomObrtxt.Enabled = false;
            this.NomObrtxt.Location = new System.Drawing.Point(140, 74);
            this.NomObrtxt.Name = "NomObrtxt";
            this.NomObrtxt.Size = new System.Drawing.Size(241, 20);
            this.NomObrtxt.TabIndex = 2;
            this.NomObrtxt.Validating += new System.ComponentModel.CancelEventHandler(this.NomObrtxt_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(19, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de Inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(19, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre de la Obra:";
            // 
            // Guardarbtn
            // 
            this.Guardarbtn.Enabled = false;
            this.Guardarbtn.Location = new System.Drawing.Point(6, 44);
            this.Guardarbtn.Name = "Guardarbtn";
            this.Guardarbtn.Size = new System.Drawing.Size(75, 23);
            this.Guardarbtn.TabIndex = 13;
            this.Guardarbtn.Text = "Guardar";
            this.Guardarbtn.UseVisualStyleBackColor = true;
            this.Guardarbtn.Click += new System.EventHandler(this.Guardarbtn_Click);
            // 
            // Limpiarbtn
            // 
            this.Limpiarbtn.Enabled = false;
            this.Limpiarbtn.Location = new System.Drawing.Point(87, 10);
            this.Limpiarbtn.Name = "Limpiarbtn";
            this.Limpiarbtn.Size = new System.Drawing.Size(75, 23);
            this.Limpiarbtn.TabIndex = 15;
            this.Limpiarbtn.Text = "Limpiar";
            this.Limpiarbtn.UseVisualStyleBackColor = true;
            this.Limpiarbtn.Click += new System.EventHandler(this.Limpiarbtn_Click);
            // 
            // Cancelarbtn
            // 
            this.Cancelarbtn.Location = new System.Drawing.Point(87, 76);
            this.Cancelarbtn.Name = "Cancelarbtn";
            this.Cancelarbtn.Size = new System.Drawing.Size(75, 23);
            this.Cancelarbtn.TabIndex = 17;
            this.Cancelarbtn.Text = "Salir";
            this.Cancelarbtn.UseVisualStyleBackColor = true;
            this.Cancelarbtn.Click += new System.EventHandler(this.Cancelarbtn_Click);
            // 
            // Avancesbtn
            // 
            this.Avancesbtn.Location = new System.Drawing.Point(6, 76);
            this.Avancesbtn.Name = "Avancesbtn";
            this.Avancesbtn.Size = new System.Drawing.Size(75, 23);
            this.Avancesbtn.TabIndex = 14;
            this.Avancesbtn.Text = "Avances";
            this.Avancesbtn.UseVisualStyleBackColor = true;
            this.Avancesbtn.Click += new System.EventHandler(this.Avancesbtn_Click);
            // 
            // BorrarObbtn
            // 
            this.BorrarObbtn.Location = new System.Drawing.Point(87, 44);
            this.BorrarObbtn.Name = "BorrarObbtn";
            this.BorrarObbtn.Size = new System.Drawing.Size(75, 23);
            this.BorrarObbtn.TabIndex = 16;
            this.BorrarObbtn.Text = "Borrar";
            this.BorrarObbtn.UseVisualStyleBackColor = true;
            this.BorrarObbtn.Click += new System.EventHandler(this.BorrarObbtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Maroon;
            this.groupBox2.Controls.Add(this.Nuevobtn);
            this.groupBox2.Controls.Add(this.Guardarbtn);
            this.groupBox2.Controls.Add(this.BorrarObbtn);
            this.groupBox2.Controls.Add(this.Limpiarbtn);
            this.groupBox2.Controls.Add(this.Avancesbtn);
            this.groupBox2.Controls.Add(this.Cancelarbtn);
            this.groupBox2.Location = new System.Drawing.Point(828, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 111);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // Nuevobtn
            // 
            this.Nuevobtn.Location = new System.Drawing.Point(6, 10);
            this.Nuevobtn.Name = "Nuevobtn";
            this.Nuevobtn.Size = new System.Drawing.Size(75, 23);
            this.Nuevobtn.TabIndex = 12;
            this.Nuevobtn.Text = "Nuevo";
            this.Nuevobtn.UseVisualStyleBackColor = true;
            this.Nuevobtn.Click += new System.EventHandler(this.Nuevobtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 305);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(398, 99);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // obrasBindingSource
            // 
            this.obrasBindingSource.DataMember = "Obras";
            this.obrasBindingSource.DataSource = this.telecomRTD_DBDataSet;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Maroon;
            this.groupBox3.Controls.Add(this.Borrarbtn);
            this.groupBox3.Controls.Add(this.Trabtxt);
            this.groupBox3.Controls.Add(this.Agregarbtn);
            this.groupBox3.Controls.Add(this.Buscarbtn);
            this.groupBox3.Controls.Add(this.Trabajadores);
            this.groupBox3.Location = new System.Drawing.Point(424, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 102);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            // 
            // Borrarbtn
            // 
            this.Borrarbtn.Enabled = false;
            this.Borrarbtn.Location = new System.Drawing.Point(206, 59);
            this.Borrarbtn.Name = "Borrarbtn";
            this.Borrarbtn.Size = new System.Drawing.Size(75, 23);
            this.Borrarbtn.TabIndex = 11;
            this.Borrarbtn.Text = "Borrar";
            this.Borrarbtn.UseVisualStyleBackColor = true;
            // 
            // Trabtxt
            // 
            this.Trabtxt.Enabled = false;
            this.Trabtxt.Location = new System.Drawing.Point(84, 16);
            this.Trabtxt.Name = "Trabtxt";
            this.Trabtxt.Size = new System.Drawing.Size(233, 20);
            this.Trabtxt.TabIndex = 8;
            // 
            // Agregarbtn
            // 
            this.Agregarbtn.Enabled = false;
            this.Agregarbtn.Location = new System.Drawing.Point(105, 59);
            this.Agregarbtn.Name = "Agregarbtn";
            this.Agregarbtn.Size = new System.Drawing.Size(75, 23);
            this.Agregarbtn.TabIndex = 10;
            this.Agregarbtn.Text = "Agregar";
            this.Agregarbtn.UseVisualStyleBackColor = true;
            this.Agregarbtn.Click += new System.EventHandler(this.Agregarbtn_Click);
            // 
            // Buscarbtn
            // 
            this.Buscarbtn.Enabled = false;
            this.Buscarbtn.Location = new System.Drawing.Point(323, 16);
            this.Buscarbtn.Name = "Buscarbtn";
            this.Buscarbtn.Size = new System.Drawing.Size(58, 23);
            this.Buscarbtn.TabIndex = 9;
            this.Buscarbtn.Text = "...";
            this.Buscarbtn.UseVisualStyleBackColor = true;
            this.Buscarbtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // Trabajadores
            // 
            this.Trabajadores.AutoSize = true;
            this.Trabajadores.ForeColor = System.Drawing.SystemColors.Control;
            this.Trabajadores.Location = new System.Drawing.Point(6, 20);
            this.Trabajadores.Name = "Trabajadores";
            this.Trabajadores.Size = new System.Drawing.Size(72, 13);
            this.Trabajadores.TabIndex = 29;
            this.Trabajadores.Text = "Trabajadores:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(424, 168);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(387, 110);
            this.dataGridView2.TabIndex = 39;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Maroon;
            this.groupBox4.Controls.Add(this.TSueltxt);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(817, 211);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(95, 40);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            // 
            // TSueltxt
            // 
            this.TSueltxt.Enabled = false;
            this.TSueltxt.Location = new System.Drawing.Point(46, 13);
            this.TSueltxt.Name = "TSueltxt";
            this.TSueltxt.Size = new System.Drawing.Size(40, 20);
            this.TSueltxt.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Total:";
            // 
            // obrasTableAdapter
            // 
            this.obrasTableAdapter.ClearBeforeFill = true;
            // 
            // autosTableAdapter
            // 
            this.autosTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(424, 305);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(387, 99);
            this.dataGridView3.TabIndex = 41;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Maroon;
            this.groupBox5.Controls.Add(this.usertxt);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(20, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(317, 47);
            this.groupBox5.TabIndex = 40;
            this.groupBox5.TabStop = false;
            // 
            // usertxt
            // 
            this.usertxt.Enabled = false;
            this.usertxt.Location = new System.Drawing.Point(72, 17);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(233, 20);
            this.usertxt.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Usuario:";
            // 
            // frmObras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(1011, 409);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmObras";
            this.Text = "Registro de Obras";
            this.Load += new System.EventHandler(this.frmModeloObras_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telecomRTD_DBDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telecomRTDDBDataSetBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox NomObrtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button Guardarbtn;
        public System.Windows.Forms.Button Limpiarbtn;
        public System.Windows.Forms.Button Cancelarbtn;
        private System.Windows.Forms.DateTimePicker FecIniDTP;
        private System.Windows.Forms.TextBox PEPtxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox IdObrastxt;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button Avancesbtn;
        public System.Windows.Forms.Button BorrarObbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox RBStxt;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button Nuevobtn;
        private System.Windows.Forms.DateTimePicker FecTerDTP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.Button Buscarbtn;
        private System.Windows.Forms.Label Trabajadores;
        public System.Windows.Forms.Button Agregarbtn;
        private System.Windows.Forms.TextBox Trabtxt;
        public System.Windows.Forms.Button Borrarbtn;
        private System.Windows.Forms.BindingSource telecomRTDDBDataSetBindingSource;
        public System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TSueltxt;
        private TelecomRTD_DBDataSet telecomRTD_DBDataSet;
        private System.Windows.Forms.BindingSource obrasBindingSource;
        private TelecomRTD_DBDataSetTableAdapters.ObrasTableAdapter obrasTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource autosBindingSource;
        private TelecomRTD_DBDataSetTableAdapters.AutosTableAdapter autosTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        public System.Windows.Forms.Button AgregarAutobtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.Label label6;
    }
}