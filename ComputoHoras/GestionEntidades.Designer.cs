namespace ComputoHoras
{
    partial class GestionEntidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionEntidades));
            this.SignOutlbl = new System.Windows.Forms.LinkLabel();
            this.lblTitleUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblUser = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTablas = new System.Windows.Forms.DataGridView();
            this.controlHorasTodasTablasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlHorasTodasTablas = new ComputoHoras.ControlHorasTodasTablas();
            this.areaFuncionalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.areaFuncionalTableAdapter = new ComputoHoras.ControlHorasTodasTablasTableAdapters.AreaFuncionalTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlHorasTodasTablasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlHorasTodasTablas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaFuncionalBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SignOutlbl
            // 
            this.SignOutlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SignOutlbl.AutoSize = true;
            this.SignOutlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOutlbl.LinkColor = System.Drawing.Color.Black;
            this.SignOutlbl.Location = new System.Drawing.Point(1272, 209);
            this.SignOutlbl.Name = "SignOutlbl";
            this.SignOutlbl.Size = new System.Drawing.Size(95, 17);
            this.SignOutlbl.TabIndex = 31;
            this.SignOutlbl.TabStop = true;
            this.SignOutlbl.Text = "Cerrar Sesion";
            // 
            // lblTitleUser
            // 
            this.lblTitleUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleUser.Location = new System.Drawing.Point(-181, 199);
            this.lblTitleUser.Name = "lblTitleUser";
            this.lblTitleUser.Size = new System.Drawing.Size(74, 36);
            this.lblTitleUser.TabIndex = 30;
            this.lblTitleUser.Text = "Usuario: ";
            this.lblTitleUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(497, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(1079, 19);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(95, 17);
            this.linkLabel1.TabIndex = 34;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Cerrar Sesion";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(8, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(74, 36);
            this.lblUser.TabIndex = 33;
            this.lblUser.Text = "Usuario: ";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(88, 9);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(308, 36);
            this.Username.TabIndex = 32;
            this.Username.Text = "Usuario";
            this.Username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AreaFuncional",
            "Clientes",
            "Cuentas",
            "Empleados",
            "Empleados_Area",
            "Imputaciones",
            "Proyectos",
            "Tareas",
            "Tareas_Tipo",
            "Tasas",
            "Tipo_Proyecto"});
            this.comboBox1.Location = new System.Drawing.Point(66, 119);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 36);
            this.label3.TabIndex = 37;
            this.label3.Text = "Tabla: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvTablas
            // 
            this.dgvTablas.AllowUserToOrderColumns = true;
            this.dgvTablas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTablas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablas.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvTablas.Location = new System.Drawing.Point(12, 149);
            this.dgvTablas.Name = "dgvTablas";
            this.dgvTablas.Size = new System.Drawing.Size(1162, 150);
            this.dgvTablas.TabIndex = 38;
            // 
            // controlHorasTodasTablasBindingSource
            // 
            this.controlHorasTodasTablasBindingSource.DataSource = this.controlHorasTodasTablas;
            this.controlHorasTodasTablasBindingSource.Position = 0;
            // 
            // controlHorasTodasTablas
            // 
            this.controlHorasTodasTablas.DataSetName = "ControlHorasTodasTablas";
            this.controlHorasTodasTablas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // areaFuncionalBindingSource
            // 
            this.areaFuncionalBindingSource.DataMember = "AreaFuncional";
            this.areaFuncionalBindingSource.DataSource = this.controlHorasTodasTablasBindingSource;
            // 
            // areaFuncionalTableAdapter
            // 
            this.areaFuncionalTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 70);
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.crearToolStripMenuItem.Text = "Crear";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.CheckOnClick = true;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // GestionEntidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1186, 671);
            this.Controls.Add(this.dgvTablas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.SignOutlbl);
            this.Controls.Add(this.lblTitleUser);
            this.Name = "GestionEntidades";
            this.Text = "GestionEntidades";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlHorasTodasTablasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlHorasTodasTablas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaFuncionalBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel SignOutlbl;
        private System.Windows.Forms.Label lblTitleUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTablas;
        private System.Windows.Forms.BindingSource controlHorasTodasTablasBindingSource;
        private ControlHorasTodasTablas controlHorasTodasTablas;
        private System.Windows.Forms.BindingSource areaFuncionalBindingSource;
        private ControlHorasTodasTablasTableAdapters.AreaFuncionalTableAdapter areaFuncionalTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}