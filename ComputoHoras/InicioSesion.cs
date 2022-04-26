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
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
            AcceptButton = btInicioSesion;
        }


        private void BtInicioSesion_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbUser.Text) && !String.IsNullOrEmpty(tbPswd.Text))
            {
                try
                {
                    BaseDatos bd = new BaseDatos();

                    Boolean result = bd.LogIn(tbUser.Text, tbPswd.Text);


                    if (result)
                    {
                        MenuPrincipal principal = new MenuPrincipal();
                        principal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Datos Incorrectos");
                    }
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Rellene los campos");
            }
        }

        private void InicioSesion_Load(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
    
}
