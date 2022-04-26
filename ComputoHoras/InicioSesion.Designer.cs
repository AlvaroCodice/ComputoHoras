namespace ComputoHoras
{
    partial class InicioSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            this.btInicioSesion = new System.Windows.Forms.Button();
            this.tbPswd = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btInicioSesion
            // 
            this.btInicioSesion.Location = new System.Drawing.Point(142, 256);
            this.btInicioSesion.Name = "btInicioSesion";
            this.btInicioSesion.Size = new System.Drawing.Size(100, 23);
            this.btInicioSesion.TabIndex = 9;
            this.btInicioSesion.Text = "Iniciar Sesion";
            this.btInicioSesion.UseVisualStyleBackColor = true;
            this.btInicioSesion.Click += new System.EventHandler(this.BtInicioSesion_Click);
            // 
            // tbPswd
            // 
            this.tbPswd.Location = new System.Drawing.Point(169, 199);
            this.tbPswd.MaxLength = 20;
            this.tbPswd.Name = "tbPswd";
            this.tbPswd.PasswordChar = '*';
            this.tbPswd.Size = new System.Drawing.Size(100, 20);
            this.tbPswd.TabIndex = 8;
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(169, 160);
            this.tbUser.MaxLength = 20;
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(100, 20);
            this.tbUser.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(98, 199);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(74, 23);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Contraseña:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUser
            // 
            this.lblUser.Location = new System.Drawing.Point(98, 158);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(56, 23);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "Usuario:";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUser.UseMnemonic = false;
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.btInicioSesion);
            this.Controls.Add(this.tbPswd);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btInicioSesion;
        private System.Windows.Forms.TextBox tbPswd;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
    }
}

