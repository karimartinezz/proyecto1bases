using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos
{
    public class ConexionBD
    {
        string cadena = @"server=KARINAMARTI6E7C\SQLEXPRESS; database=TuSalud; integrated security=true";

        //objetivo tipo SQL Connection
        public SqlConnection sqlConnection = new SqlConnection();

        public void openConnection()
        {
            sqlConnection.ConnectionString= cadena;
            try
            {
                sqlConnection.Open();
                Console.WriteLine("Connection started");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection problem"+ex.Message);
            }
        }
        public void closeConnection()
        {
            sqlConnection.Close();
        }

        public int generarID(string nombreTabla, string nombreColumna)
        {

            int nuevoID = 1;
            openConnection();
            
            string query = "SELECT MAX(" + nombreColumna + ") FROM " + nombreTabla ;
            SqlCommand command = new SqlCommand(query, sqlConnection);
            object result = command.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
             nuevoID = Convert.ToInt32(result) + 1;
            }
            closeConnection();  
            return nuevoID;

        }
        public void registrarCitaDAO(int id, string observaciones, string area, TimeSpan hora, string fecha, string estado)
        {
            string cadena = "INSERT INTO Cita VALUES (" + id + ",'" + fecha + "', '" + hora + "', '" + estado + "', '" + observaciones + "','" + area + "', NULL, NULL )";
            Console.WriteLine(" cadena: " + cadena);
            openConnection();
            try
            {
                SqlCommand comando = new SqlCommand(cadena, sqlConnection);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection problem" + ex.Message);
            }
            
            closeConnection();
        }
    }
}
