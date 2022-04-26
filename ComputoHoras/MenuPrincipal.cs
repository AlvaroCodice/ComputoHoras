using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputoHoras
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            lblUser.Text = BaseDatos.Username;

            if (BaseDatos.Username.Equals("alvaro"))
            {
                btEntities.Visible = true;
                btHours.Visible = true;
            }
            else
            {
                btHours.Visible = true;
            }
        }


        
        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SignOutlbl_LinkClicked(object sender, EventArgs e)
        {
           // InicioSesion inicioSesion = inicioSesion;
           // inicioSesion.Show();
           // this.Close();
        }
        private void Principal_Load(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtEntities_Click(object sender, EventArgs e)
        {
            GestionEntidades gestionEntidades = new GestionEntidades();
            gestionEntidades.Show();
            this.Hide();
        }

        private void BtHours_Click(object sender, EventArgs e)
        {
            RegistroHoras registroHoras = new RegistroHoras();
            registroHoras.Show();
            this.Hide();
        }
    }
}
