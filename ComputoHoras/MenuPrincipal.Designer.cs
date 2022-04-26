namespace ComputoHoras
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.UserPanel = new System.Windows.Forms.Panel();
            this.btHours = new System.Windows.Forms.Button();
            this.btEntities = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblTitleUser = new System.Windows.Forms.Label();
            this.SignOutlbl = new System.Windows.Forms.LinkLabel();
            this.UserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserPanel
            // 
            this.UserPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UserPanel.Controls.Add(this.btHours);
            this.UserPanel.Controls.Add(this.btEntities);
            this.UserPanel.Location = new System.Drawing.Point(12, 91);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(773, 349);
            this.UserPanel.TabIndex = 8;
            // 
            // btHours
            // 
            this.btHours.Location = new System.Drawing.Point(300, 167);
            this.btHours.Name = "btHours";
            this.btHours.Size = new System.Drawing.Size(149, 23);
            this.btHours.TabIndex = 0;
            this.btHours.Text = "Registro de Horas";
            this.btHours.UseVisualStyleBackColor = true;
            this.btHours.Visible = false;
            this.btHours.Click += new System.EventHandler(this.BtHours_Click);
            // 
            // btEntities
            // 
            this.btEntities.Location = new System.Drawing.Point(300, 119);
            this.btEntities.Name = "btEntities";
            this.btEntities.Size = new System.Drawing.Size(149, 23);
            this.btEntities.TabIndex = 1;
            this.btEntities.Text = "Gestionar Entidades";
            this.btEntities.UseVisualStyleBackColor = true;
            this.btEntities.Visible = false;
            this.btEntities.Click += new System.EventHandler(this.BtEntities_Click);
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(95, 11);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(308, 36);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "Usuario";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitleUser
            // 
            this.lblTitleUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleUser.Location = new System.Drawing.Point(15, 11);
            this.lblTitleUser.Name = "lblTitleUser";
            this.lblTitleUser.Size = new System.Drawing.Size(74, 36);
            this.lblTitleUser.TabIndex = 9;
            this.lblTitleUser.Text = "Usuario: ";
            this.lblTitleUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SignOutlbl
            // 
            this.SignOutlbl.AutoSize = true;
            this.SignOutlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOutlbl.LinkColor = System.Drawing.Color.Black;
            this.SignOutlbl.Location = new System.Drawing.Point(693, 21);
            this.SignOutlbl.Name = "SignOutlbl";
            this.SignOutlbl.Size = new System.Drawing.Size(95, 17);
            this.SignOutlbl.TabIndex = 10;
            this.SignOutlbl.TabStop = true;
            this.SignOutlbl.Text = "Cerrar Sesion";
            this.SignOutlbl.Click += new System.EventHandler(this.SignOutlbl_LinkClicked);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SignOutlbl);
            this.Controls.Add(this.UserPanel);
            this.Controls.Add(this.lblTitleUser);
            this.Controls.Add(this.lblUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.UserPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.Button btEntities;
        private System.Windows.Forms.Button btHours;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblTitleUser;
        private System.Windows.Forms.LinkLabel SignOutlbl;
    }
}