namespace ComputoHoras
{
    partial class RegistroHoras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroHoras));
            this.SignOutlbl = new System.Windows.Forms.LinkLabel();
            this.lblTitleUser = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.btBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fECHAIMPUTACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTAREADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDEMPLEADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imputacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlHorasDataSet = new ComputoHoras.ControlHorasDataSet();
            this.imputacionesTableAdapter = new ComputoHoras.ControlHorasDataSetTableAdapters.ImputacionesTableAdapter();
            this.btInsertar = new System.Windows.Forms.Button();
            this.btAtras = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pbInsertar = new System.Windows.Forms.PictureBox();
            this.tbEmpleado = new System.Windows.Forms.TextBox();
            this.tbTarea = new System.Windows.Forms.TextBox();
            this.tbHoras = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblHorasInsertadas = new System.Windows.Forms.Label();
            this.lblTotalHoras = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.FormularioInsert = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imputacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlHorasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInsertar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.FormularioInsert.SuspendLayout();
            this.SuspendLayout();
            // 
            // SignOutlbl
            // 
            this.SignOutlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SignOutlbl.AutoSize = true;
            this.SignOutlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOutlbl.LinkColor = System.Drawing.Color.Black;
            this.SignOutlbl.Location = new System.Drawing.Point(1079, 19);
            this.SignOutlbl.Name = "SignOutlbl";
            this.SignOutlbl.Size = new System.Drawing.Size(95, 17);
            this.SignOutlbl.TabIndex = 13;
            this.SignOutlbl.TabStop = true;
            this.SignOutlbl.Text = "Cerrar Sesion";
            // 
            // lblTitleUser
            // 
            this.lblTitleUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleUser.Location = new System.Drawing.Point(12, 9);
            this.lblTitleUser.Name = "lblTitleUser";
            this.lblTitleUser.Size = new System.Drawing.Size(74, 36);
            this.lblTitleUser.TabIndex = 12;
            this.lblTitleUser.Text = "Usuario: ";
            this.lblTitleUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(92, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(308, 36);
            this.lblUser.TabIndex = 11;
            this.lblUser.Text = "Usuario";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInicio
            // 
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(9, 67);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(49, 36);
            this.lblInicio.TabIndex = 14;
            this.lblInicio.Text = "Inicio:";
            this.lblInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFin
            // 
            this.lblFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFin.Location = new System.Drawing.Point(98, 67);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(49, 36);
            this.lblFin.TabIndex = 15;
            this.lblFin.Text = "Fin";
            this.lblFin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(12, 98);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(80, 20);
            this.dtInicio.TabIndex = 16;
            this.dtInicio.Value = new System.DateTime(2022, 4, 18, 0, 0, 0, 0);
            // 
            // dtFin
            // 
            this.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFin.Location = new System.Drawing.Point(101, 98);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(80, 20);
            this.dtFin.TabIndex = 17;
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btBuscar.Location = new System.Drawing.Point(187, 98);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 20);
            this.btBuscar.TabIndex = 18;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.BtBuscar_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fECHAIMPUTACIONDataGridViewTextBoxColumn,
            this.hORASDataGridViewTextBoxColumn,
            this.iDTAREADataGridViewTextBoxColumn,
            this.iDEMPLEADODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.imputacionesBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.Location = new System.Drawing.Point(15, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1159, 150);
            this.dataGridView1.TabIndex = 19;
            // 
            // fECHAIMPUTACIONDataGridViewTextBoxColumn
            // 
            this.fECHAIMPUTACIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fECHAIMPUTACIONDataGridViewTextBoxColumn.DataPropertyName = "FECHA_IMPUTACION";
            this.fECHAIMPUTACIONDataGridViewTextBoxColumn.HeaderText = "FECHA_IMPUTACION";
            this.fECHAIMPUTACIONDataGridViewTextBoxColumn.Name = "fECHAIMPUTACIONDataGridViewTextBoxColumn";
            this.fECHAIMPUTACIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hORASDataGridViewTextBoxColumn
            // 
            this.hORASDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hORASDataGridViewTextBoxColumn.DataPropertyName = "HORAS";
            this.hORASDataGridViewTextBoxColumn.HeaderText = "HORAS";
            this.hORASDataGridViewTextBoxColumn.Name = "hORASDataGridViewTextBoxColumn";
            this.hORASDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDTAREADataGridViewTextBoxColumn
            // 
            this.iDTAREADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDTAREADataGridViewTextBoxColumn.DataPropertyName = "ID_TAREA";
            this.iDTAREADataGridViewTextBoxColumn.HeaderText = "ID_TAREA";
            this.iDTAREADataGridViewTextBoxColumn.Name = "iDTAREADataGridViewTextBoxColumn";
            this.iDTAREADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDEMPLEADODataGridViewTextBoxColumn
            // 
            this.iDEMPLEADODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDEMPLEADODataGridViewTextBoxColumn.DataPropertyName = "ID_EMPLEADO";
            this.iDEMPLEADODataGridViewTextBoxColumn.HeaderText = "ID_EMPLEADO";
            this.iDEMPLEADODataGridViewTextBoxColumn.Name = "iDEMPLEADODataGridViewTextBoxColumn";
            this.iDEMPLEADODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imputacionesBindingSource
            // 
            this.imputacionesBindingSource.DataMember = "Imputaciones";
            this.imputacionesBindingSource.DataSource = this.controlHorasDataSet;
            // 
            // controlHorasDataSet
            // 
            this.controlHorasDataSet.DataSetName = "ControlHorasDataSet";
            this.controlHorasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imputacionesTableAdapter
            // 
            this.imputacionesTableAdapter.ClearBeforeFill = true;
            // 
            // btInsertar
            // 
            this.btInsertar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btInsertar.Location = new System.Drawing.Point(501, 280);
            this.btInsertar.Name = "btInsertar";
            this.btInsertar.Size = new System.Drawing.Size(75, 20);
            this.btInsertar.TabIndex = 20;
            this.btInsertar.Text = "Insertar";
            this.btInsertar.UseVisualStyleBackColor = true;
            this.btInsertar.Click += new System.EventHandler(this.BtInsertar_Click);
            // 
            // btAtras
            // 
            this.btAtras.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btAtras.Location = new System.Drawing.Point(608, 280);
            this.btAtras.Name = "btAtras";
            this.btAtras.Size = new System.Drawing.Size(75, 20);
            this.btAtras.TabIndex = 21;
            this.btAtras.Text = "Atras";
            this.btAtras.UseVisualStyleBackColor = true;
            this.btAtras.Click += new System.EventHandler(this.BtAtras_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Insertar";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbInsertar
            // 
            this.pbInsertar.Image = global::ComputoHoras.Properties.Resources.insertar;
            this.pbInsertar.Location = new System.Drawing.Point(70, 135);
            this.pbInsertar.Name = "pbInsertar";
            this.pbInsertar.Size = new System.Drawing.Size(54, 32);
            this.pbInsertar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInsertar.TabIndex = 28;
            this.pbInsertar.TabStop = false;
            this.pbInsertar.Click += new System.EventHandler(this.PbInsertar_Click);
            // 
            // tbEmpleado
            // 
            this.tbEmpleado.Location = new System.Drawing.Point(61, 109);
            this.tbEmpleado.Name = "tbEmpleado";
            this.tbEmpleado.Size = new System.Drawing.Size(100, 20);
            this.tbEmpleado.TabIndex = 30;
            // 
            // tbTarea
            // 
            this.tbTarea.Location = new System.Drawing.Point(61, 79);
            this.tbTarea.Name = "tbTarea";
            this.tbTarea.Size = new System.Drawing.Size(100, 20);
            this.tbTarea.TabIndex = 29;
            // 
            // tbHoras
            // 
            this.tbHoras.Location = new System.Drawing.Point(61, 49);
            this.tbHoras.Name = "tbHoras";
            this.tbHoras.Size = new System.Drawing.Size(100, 20);
            this.tbHoras.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Horas:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Id Tarea:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Empleado:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Fecha:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHoras
            // 
            this.lblHoras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.Location = new System.Drawing.Point(1124, 82);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(50, 36);
            this.lblHoras.TabIndex = 25;
            this.lblHoras.Text = "horas";
            this.lblHoras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHorasInsertadas
            // 
            this.lblHorasInsertadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHorasInsertadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasInsertadas.Location = new System.Drawing.Point(1086, 82);
            this.lblHorasInsertadas.Name = "lblHorasInsertadas";
            this.lblHorasInsertadas.Size = new System.Drawing.Size(32, 36);
            this.lblHorasInsertadas.TabIndex = 26;
            this.lblHorasInsertadas.Text = "0";
            this.lblHorasInsertadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalHoras
            // 
            this.lblTotalHoras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHoras.Location = new System.Drawing.Point(988, 82);
            this.lblTotalHoras.Name = "lblTotalHoras";
            this.lblTotalHoras.Size = new System.Drawing.Size(103, 36);
            this.lblTotalHoras.TabIndex = 27;
            this.lblTotalHoras.Text = "Total Horas:";
            this.lblTotalHoras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(501, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(62, 25);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 13);
            this.lblDate.TabIndex = 32;
            // 
            // FormularioInsert
            // 
            this.FormularioInsert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FormularioInsert.Controls.Add(this.lblDate);
            this.FormularioInsert.Controls.Add(this.label5);
            this.FormularioInsert.Controls.Add(this.pbInsertar);
            this.FormularioInsert.Controls.Add(this.tbEmpleado);
            this.FormularioInsert.Controls.Add(this.tbTarea);
            this.FormularioInsert.Controls.Add(this.tbHoras);
            this.FormularioInsert.Controls.Add(this.label4);
            this.FormularioInsert.Controls.Add(this.label3);
            this.FormularioInsert.Controls.Add(this.label2);
            this.FormularioInsert.Controls.Add(this.label1);
            this.FormularioInsert.Location = new System.Drawing.Point(501, 321);
            this.FormularioInsert.Name = "FormularioInsert";
            this.FormularioInsert.Size = new System.Drawing.Size(182, 190);
            this.FormularioInsert.TabIndex = 22;
            this.FormularioInsert.TabStop = false;
            this.FormularioInsert.Visible = false;
            // 
            // RegistroHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1186, 671);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTotalHoras);
            this.Controls.Add(this.lblHorasInsertadas);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.FormularioInsert);
            this.Controls.Add(this.btAtras);
            this.Controls.Add(this.btInsertar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.dtFin);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.SignOutlbl);
            this.Controls.Add(this.lblTitleUser);
            this.Controls.Add(this.lblUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistroHoras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroHoras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RegistroHoras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imputacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlHorasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInsertar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.FormularioInsert.ResumeLayout(false);
            this.FormularioInsert.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel SignOutlbl;
        private System.Windows.Forms.Label lblTitleUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFin;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ControlHorasDataSet controlHorasDataSet;
        private System.Windows.Forms.BindingSource imputacionesBindingSource;
        private ControlHorasDataSetTableAdapters.ImputacionesTableAdapter imputacionesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAIMPUTACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTAREADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEMPLEADODataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btInsertar;
        private System.Windows.Forms.Button btAtras;
        private System.Windows.Forms.TextBox tbEmpleado;
        private System.Windows.Forms.TextBox tbTarea;
        private System.Windows.Forms.TextBox tbHoras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblHorasInsertadas;
        private System.Windows.Forms.Label lblTotalHoras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbInsertar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox FormularioInsert;
    }
}