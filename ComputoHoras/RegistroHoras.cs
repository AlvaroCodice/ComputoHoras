using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ComputoHoras
{
   public partial class RegistroHoras : Form
   {
     private readonly string CadenaConexion = @"Data Source=TERESA\SERVERSQL;Initial Catalog=ControlHoras;Integrated Security=True";
      public RegistroHoras()
      {
        InitializeComponent();
        SetDate();
        lblHorasInsertadas.Text = HorasImputadas(dtInicio.Value, dtFin.Value);
        dataGridView1.DataSource = Listado(dtInicio.Value, dtFin.Value);
        lblDate.Text = DateTime.Now.ToShortDateString();
      }

      private void SetDate()
        {
            lblUser.Text = BaseDatos.Username;
            DateTime date = DateTime.Now;
            DateTime semana = DateTime.Now.AddDays(7);
            dtInicio.Value = date;
            dtFin.Value = semana;
        }
      private void BtBack_Click(object sender, LinkLabelLinkClickedEventArgs e)
      {
        MenuPrincipal principal = new MenuPrincipal();
        principal.Show();
        this.Close();
      }

        private void BtInsertar_Click(object sender, EventArgs e)
        {
        FormularioInsert.Visible = true;
      }

      public DataTable Listado(DateTime inicio, DateTime fin)
      {
        DataTable dt = new DataTable();

        using (SqlConnection con = new SqlConnection(CadenaConexion))
        {
          con.Open();
          SqlCommand cmd = new SqlCommand(
                        @"SELECT * FROM Imputaciones
                        WHERE CAST(CONVERT(CHAR(8), FECHA_IMPUTACION, 112) AS INT) 
                        BETWEEN CAST(CONVERT(CHAR(8), @inicio, 112) AS INT) 
                        AND CAST(CONVERT(CHAR(8), @fin, 112) AS INT)"
                        , con);

          cmd.Parameters.AddWithValue("@inicio", inicio);
          cmd.Parameters.AddWithValue("@fin", fin);

          SqlDataAdapter da = new SqlDataAdapter(cmd);
          da.Fill(dt);
          cmd.Dispose();
          con.Close();
         }
         return dt;
      }

        public String HorasImputadas(DateTime inicio, DateTime fin)
        {

            SqlConnection conn = new SqlConnection(CadenaConexion);
            conn.Open();
            SqlCommand cmd = new SqlCommand(
                          @"SELECT SUM(HORAS) FROM Imputaciones
                       WHERE CAST(CONVERT(CHAR(8), FECHA_IMPUTACION, 112) AS INT) 
                       BETWEEN CAST(CONVERT(CHAR(8), @inicio, 112) AS INT)
                       AND CAST(CONVERT(CHAR(8), @fin, 112) AS INT)"
                          , conn);
            cmd.Parameters.AddWithValue("@inicio", inicio);
            cmd.Parameters.AddWithValue("@fin", fin);

            if (cmd.ExecuteScalar().Equals(DBNull.Value))
            {
                String sums = "0";
                return sums;
            }
            else
            {
                double sum = Convert.ToDouble(cmd.ExecuteScalar());
                conn.Close();

                if (sum <= 40)
                {
                    lblHorasInsertadas.ForeColor = System.Drawing.Color.Green;
                    lblHoras.ForeColor = System.Drawing.Color.Green;
                    String suma = Convert.ToString(sum);
                    return suma;
                }
                else
                {
                    lblHorasInsertadas.ForeColor = System.Drawing.Color.Red;
                    lblHoras.ForeColor = System.Drawing.Color.Red;
                    String suma = Convert.ToString(sum);
                    return suma;
                }
            }

        }
            
   


      private void BtBuscar_Click_1(object sender, EventArgs e)
      {
         dataGridView1.DataSource = Listado(dtInicio.Value, dtFin.Value);
         lblHorasInsertadas.Text = HorasImputadas(dtInicio.Value, dtFin.Value);
      }
      private void Cargar()
      {
         using (SqlConnection conn = new SqlConnection(@"Data Source=TERESA\SERVERSQL;Initial Catalog=ControlHoras;Integrated Security=True"))
         {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Imputaciones";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
             adap.Fill(dt);

             dataGridView1.DataSource = dt;
         }
      }

       private void BtAtras_Click(object sender, EventArgs e)
       {
          MenuPrincipal principal = new MenuPrincipal();
          principal.Show();
          this.Close();
       }

       private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
       {
          InicioSesion form1 = new InicioSesion();
          form1.Show();
          this.Close();
       }

        private void RegistroHoras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'controlHorasDataSet.Imputaciones' Puede moverla o quitarla según sea necesario.
            this.imputacionesTableAdapter.Fill(this.controlHorasDataSet.Imputaciones);

        }

        private void PbInsertar_Click(object sender, EventArgs e)
        {
            if ( tbTarea.Text.Equals("") || tbHoras.Text.Equals("") || tbEmpleado.Text.Equals(""))
            {
                MessageBox.Show("Debe rellenar todos los campos");
            }
            else
            {
                string date = lblDate.Text = DateTime.Now.ToShortDateString();
                double horas = double.Parse(tbHoras.Text);
                int tarea = int.Parse(tbTarea.Text);
                int empleado = int.Parse(tbEmpleado.Text);

                using (SqlConnection con = new SqlConnection(@"Data Source=TERESA\SERVERSQL;Initial Catalog=ControlHoras;Integrated Security=True"))
                {
                    con.Open();
                    SqlParameter ClientParameter = new SqlParameter("@client", date);
                    SqlParameter TimeParameter = new SqlParameter("@time", horas);
                    SqlParameter TareaParameter = new SqlParameter("@tarea", tarea);
                    SqlParameter EmpleadoParameter = new SqlParameter("@empleado", empleado);
                    SqlCommand command = new SqlCommand("INSERT INTO Imputaciones(FECHA_IMPUTACION, HORAS, ID_TAREA, ID_EMPLEADO) VALUES(@client, @time, @tarea, @empleado)", con);
                    command.Parameters.Add(ClientParameter);
                    command.Parameters.Add(TimeParameter);
                    command.Parameters.Add(TareaParameter);
                    command.Parameters.Add(EmpleadoParameter);

                    int row = command.ExecuteNonQuery();

                    if (row > 0)
                    {
                        MessageBox.Show("Insertado correctamente");
                        Cargar();
                        FormularioInsert.Visible = false;
                        lblHorasInsertadas.Text = HorasImputadas(dtInicio.Value, dtFin.Value);
                    }
                    else
                    {
                        MessageBox.Show("No se pudieron insertar los datos");
                    }
                }

                tbTarea.ResetText();
                tbHoras.ResetText();
                tbEmpleado.ResetText();
            }
        }
    }
}

