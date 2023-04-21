using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    internal class CentroAtencion
    {
        public class ConexionBD
        {
            string cadena = @"server=KARINAMARTI6E7C\SQLEXPRESS; database=TuSalud; integrated security=true";

            //objetivo tipo SQL Connection
            public SqlConnection sqlConnection = new SqlConnection();

            public void openConnection()
            {
                sqlConnection.ConnectionString = cadena;
                try
                {
                    sqlConnection.Open();
                    Console.WriteLine("Connection started");

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Connection problem" + ex.Message);
                }
            }
            public void closeConnection()
            {
                sqlConnection.Close();
            }

            public int generarCodigoCA(string nombreTabla, string nombreColumna)
            {
                int IDnuevoCA = 1;
                openConnection();

                string query = "SELECT MAX(" + nombreColumna + ") FROM " + nombreTabla;
                SqlCommand command = new SqlCommand(query, sqlConnection);
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    IDnuevoCA = Convert.ToInt32(result) + 1;
                }
                closeConnection();
                return IDnuevoCA;
            }
            public void registrarCA(int IDnuevoCA, string nombreCA, int capacidadCA, string ubicacionCA, string tipoCA)
            {
                string cadena = "INSERT INTO Centro_Atencion VALUES (" + IDnuevoCA + ",'" + nombreCA + "', '" + capacidadCA + "', '" + ubicacionCA + "', '" + tipoCA + ")";
                openConnection();
                try
                {
                    SqlCommand comando = new SqlCommand(cadena, sqlConnection);
                    comando.ExecuteNonQuery();
                    Console.WriteLine("Registrado con exito" );
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Connection problem" + ex.Message);
                }

                closeConnection();
            }
            
}
