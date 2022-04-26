using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ComputoHoras
{
    class BaseDatos
    {
        private readonly string CadenaConexion = @"Data Source=TERESA\SERVERSQL;Initial Catalog=ControlHoras;Integrated Security=True";

        public static string Id = "";
        public static string Username = "";
        

        public Boolean LogIn(string user, string pswd)
        {
            SqlConnection Conexion = new SqlConnection(CadenaConexion);
            Conexion.Open();

            SqlParameter UserParameter = new SqlParameter("@user", user);
            SqlParameter NameParameter = new SqlParameter("@pswd", pswd);

            SqlCommand command = new SqlCommand("SELECT Usuario, Password FROM Empleados WHERE Usuario = @user AND Password = @pswd", Conexion);
            command.Parameters.Add(UserParameter);
            command.Parameters.Add(NameParameter);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
               
                Username = reader.GetString(0);
                
            }

            reader.Close();
            Conexion.Close();

            if (String.IsNullOrEmpty(Username))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
