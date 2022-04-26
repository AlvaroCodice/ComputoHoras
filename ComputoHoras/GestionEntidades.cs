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

namespace ComputoHoras
{
    public partial class GestionEntidades : Form
    {
        public GestionEntidades()
        {
            InitializeComponent();
            Username.Text = BaseDatos.Username;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String tabla = comboBox1.SelectedItem.ToString();

            if (tabla.Equals("AreaFuncional"))
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=TERESA\SERVERSQL;Initial Catalog=ControlHoras;Integrated Security=True"))
                    {
                        DataTable dt = new DataTable();
                        string query = "SELECT * FROM AreaFuncional";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        SqlDataAdapter adap = new SqlDataAdapter(cmd);
                        adap.Fill(dt);

                        dgvTablas.DataSource = dt;
                    }
            }
            else if (tabla.Equals("Clientes"))
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=TERESA\SERVERSQL;Initial Catalog=ControlHoras;Integrated Security=True"))
                {
                    DataTable dt = new DataTable();
                    string query = "SELECT * FROM Clientes";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adap = new SqlDataAdapter(cmd);
                    adap.Fill(dt);

                    dgvTablas.DataSource = dt;
                }
            }
            else if (tabla.Equals("Cuentas"))
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=TERESA\SERVERSQL;Initial Catalog=ControlHoras;Integrated Security=True"))
                {
                    DataTable dt = new DataTable();
                    string query = "SELECT * FROM Cuentas";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adap = new SqlDataAdapter(cmd);
                    adap.Fill(dt);

                    dgvTablas.DataSource = dt;
                }
            }
            else if (tabla.Equals("Empleados"))
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=TERESA\SERVERSQL;Initial Catalog=ControlHoras;Integrated Security=True"))
                {
                    DataTable dt = new DataTable();
                    string query = "SELECT * FROM Empleados";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adap = new SqlDataAdapter(cmd);
                    adap.Fill(dt);

                    dgvTablas.DataSource = dt;
                }
            }
            else if (tabla.Equals("Empleados_Area"))
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=TERESA\SERVERSQL;Initial Catalog=ControlHoras;Integrated Security=True"))
                {
                    DataTable dt = new DataTable();
                    string query = "SELECT * FROM Empleados_Area";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adap = new SqlDataAdapter(cmd);
                    adap.Fill(dt);

                    dgvTablas.DataSource = dt;
                }
            }
            else if (tabla.Equals("Imputaciones"))
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=TERESA\SERVERSQL;Initial Catalog=ControlHoras;Integrated Security=True"))
                {
                    DataTable dt = new DataTable();
                    string query = "SELECT * FROM Imputaciones";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adap = new SqlDataAdapter(cmd);
                    adap.Fill(dt);

                    dgvTablas.DataSource = dt;
                }
            }
            else if (tabla.Equals("Proyectos"))
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=TERESA\SERVERSQL;Initial Catalog=ControlHoras;Integrated Security=True"))
                {
                    DataTable dt = new DataTable();
                    string query = "SELECT * FROM Proyectos";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adap = new SqlDataAdapter(cmd);
                    adap.Fill(dt);

                    dgvTablas.DataSource = dt;
                }
            }
            else if (tabla.Equals("Tareas"))
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=TERESA\SERVERSQL;Initial Catalog=ControlHoras;Integrated Security=True"))
                {
                    DataTable dt = new DataTable();
                    string query = "SELECT * FROM Tareas";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adap = new SqlDataAdapter(cmd);
                    adap.Fill(dt);

                    dgvTablas.DataSource = dt;
                }
            }
            else if (tabla.Equals("Tareas_Tipo"))
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=TERESA\SERVERSQL;Initial Catalog=ControlHoras;Integrated Security=True"))
                {
                    DataTable dt = new DataTable();
                    string query = "SELECT * FROM Tareas_Tipo";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adap = new SqlDataAdapter(cmd);
                    adap.Fill(dt);

                    dgvTablas.DataSource = dt;
                }
            }
            else if (tabla.Equals("Tasas"))
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=TERESA\SERVERSQL;Initial Catalog=ControlHoras;Integrated Security=True"))
                {
                    DataTable dt = new DataTable();
                    string query = "SELECT * FROM Tasas";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adap = new SqlDataAdapter(cmd);
                    adap.Fill(dt);

                    dgvTablas.DataSource = dt;
                }
            }
            else if (tabla.Equals("Tipo_Proyecto"))
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=TERESA\SERVERSQL;Initial Catalog=ControlHoras;Integrated Security=True"))
                {
                    DataTable dt = new DataTable();
                    string query = "SELECT * FROM Tipo_Proyecto";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adap = new SqlDataAdapter(cmd);
                    adap.Fill(dt);

                    dgvTablas.DataSource = dt;
                };
            }
        }

     

        public bool IsPressed { get; protected set; }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InicioSesion form1 = new InicioSesion();
            form1.Show();
            this.Close();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String tabla = comboBox1.SelectedItem.ToString();
            int rows = dgvTablas.Rows.Count;
            for (int i = 0; i < dgvTablas.Rows.Count; i++)
            {
                dgvTablas.Rows.RemoveAt(i);
            }

            int row = dgvTablas.SelectedRows.Count;

            using (SqlConnection conn = new SqlConnection(@"Data Source=TERESA\SERVERSQL;Initial Catalog=ControlHoras;Integrated Security=True"))
            {
                DataTable dt = new DataTable();
                String query = "DELETE FROM @tabla WHERE row = @row";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);

                dgvTablas.DataSource = dt;


            }
        }
        
    }
}
