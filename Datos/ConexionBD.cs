using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
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

        public int generarID(string nombreTabla, string nombreColumna)
        {

            int nuevoID = 1;
            openConnection();

            string query = "SELECT MAX(" + nombreColumna + ") FROM " + nombreTabla;
            SqlCommand command = new SqlCommand(query, sqlConnection);
            object result = command.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                nuevoID = Convert.ToInt32(result) + 1;
            }
            closeConnection();
            return nuevoID;

        }
        public int validarExistenciaPaciente(int cedula)
        {
            string cadena = "SELECT COUNT(*) FROM Paciente WHERE cedula = @cedula";
            int contador = 0;
            openConnection();
            try
            {
                SqlCommand comando = new SqlCommand(cadena, sqlConnection);
                comando.Parameters.AddWithValue("@cedula", cedula);

                int count = (int)comando.ExecuteScalar();

                contador = count;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection problem" + ex.Message);
            }

            closeConnection();
            return contador;
        }
        public void registrarCitaDAO(int id, string observaciones, string area, TimeSpan hora, string fecha, string estado, int cedula)
        {
            string cadena = "INSERT INTO Cita VALUES (" + id + ",'" + fecha + "', '" + hora + "', '" + estado + "', '" + observaciones + "','" + area + "', NULL, NULL )";
            openConnection();
            try
            {
                SqlCommand comando = new SqlCommand(cadena, sqlConnection);
                comando.ExecuteNonQuery();
                string cadena2 = "INSERT INTO Paciente_cita VALUES (" + id + ", " +cedula+"  )";
                SqlCommand comando2 = new SqlCommand(cadena2, sqlConnection);
                comando2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection problem" + ex.Message);
            }

            closeConnection();
        }
        public int validarPacienteCita(string cedulaPaciente)
        {
            string cadena = "SELECT COUNT(*) FROM Paciente_cita WHERE cedulaPaciente = @cedulaPaciente";
            int contador = 0;
            openConnection();
            try
            {
                SqlCommand comando = new SqlCommand(cadena, sqlConnection);
                comando.Parameters.AddWithValue("@cedulaPaciente", cedulaPaciente);

                int count = (int)comando.ExecuteScalar();
                contador = count;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection problem" + ex.Message);
            }

            closeConnection();
            return contador;
        }
        public DataTable ejecutarConsulta(string consulta)
        {
            try
            {
                // Crear un objeto SqlCommand para ejecutar la consulta SQL
                SqlCommand comando = new SqlCommand(consulta, sqlConnection);

                // Crear un objeto SqlDataAdapter para almacenar los resultados de la consulta
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                // Crear un objeto DataTable para almacenar los resultados de la consulta
                DataTable tabla = new DataTable();

                // Ejecutar la consulta y guardar los resultados en la tabla
                adaptador.Fill(tabla);

                // Retornar la tabla con los resultados
                return tabla;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                return null;
            }
        }
        public int validarPacienteCita(int cedulaPaciente, string fecha, TimeSpan hora )
        {
            // Definir una variable para guardar el IDCita encontrado
            int idCitaEncontrada = -1;
            // Crear una consulta SQL para buscar la cita del paciente
            string consulta = $"SELECT IDcita FROM Paciente_Cita WHERE cedulaPaciente = '{cedulaPaciente}'";

            // Ejecutar la consulta y guardar los resultados en un DataTable
            DataTable resultado = ejecutarConsulta(consulta);

            // Recorrer los resultados para buscar una coincidencia de fecha y hora en la tabla "Cita"
            foreach (DataRow row in resultado.Rows)
            {
                // Obtener el IDCita del resultado actual
                int idCita = int.Parse(row["IDCita"].ToString());

                // Restar un día a la fecha de la cita
                DateTime fechaCitaMinima = DateTime.ParseExact(fecha, "yyyy-MM-dd", CultureInfo.InvariantCulture).AddDays(-1);

                // Obtener la fecha actual
                DateTime fechaActual = DateTime.Today;

                // Crear una consulta SQL para buscar la cita con el IDCita actual
                string consultaCita = $"SELECT * FROM Cita WHERE ID = {idCita} AND fecha = '{fecha}' AND hora = '{hora.ToString()}'";

                // Ejecutar la consulta y guardar los resultados en un DataTable
                DataTable resultadoCita = ejecutarConsulta(consultaCita);


                // Verificar si se encontró una coincidencia y si cumple la condición de fecha mínima
                if (resultadoCita.Rows.Count > 0 )
                {

                    if (fechaActual >= fechaCitaMinima)
                    {
                        idCitaEncontrada = -2;
                    }
                    else
                    {
                        // Guardar el IDCita y salir del bucle
                        idCitaEncontrada = idCita;

                    }
                    
                    break;
                }

            }
            return idCitaEncontrada;
        }
        public int validarCancelacionCentro(int idCita)
        {
            string cadena = "SELECT Estado FROM Cita WHERE [ID] = @IdCita";
            openConnection();
            int resultado = 0;
            try
            {
                SqlCommand comando = new SqlCommand(cadena, sqlConnection);
                comando.Parameters.AddWithValue("@IdCita", idCita);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    string estado = reader.GetString(0);
                    resultado = estado.Equals("Cancelada por centro medico") ? 1 : 0;
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection problem" + ex.Message);
            }

            closeConnection();
            return resultado;
        }
        public void modificarEstadoCita(int id, string nuevoEstado)
        {
            string cadena = "UPDATE Cita SET estado = @nuevoEstado WHERE id = @id";
            openConnection();
            try
            {
                SqlCommand comando = new SqlCommand(cadena, sqlConnection);
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@nuevoEstado", nuevoEstado);
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection problem" + ex.Message);
            }

            closeConnection();
        }
        
        public void bitacoraPaciente(int id, int cedula, string nuevoEstado, string fecha, TimeSpan hora)
        {
            string cadena = "INSERT INTO Bitacora VALUES (" + id + ",'" + fecha + "', '" + hora + "', '" + cedula + "',NULL,'" + nuevoEstado + "')";
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
        public void bitacoraFuncionario(int id, int cedula, string nuevoEstado, string fecha, TimeSpan hora)
        {
            string cadena = "INSERT INTO Bitacora VALUES (" + id + ",'" + fecha + "', '" + hora + "', NULL,'" + cedula + "','" + nuevoEstado + "')";
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
        public int validarExistenciaFuncionario(int cedula)
        {
            string cadena = "SELECT COUNT(*) FROM Funcionario WHERE cedula = @cedula";
            int contador = 0;
            openConnection();
            try
            {
                SqlCommand comando = new SqlCommand(cadena, sqlConnection);
                comando.Parameters.AddWithValue("@cedula", cedula);

                int count = (int)comando.ExecuteScalar();

                contador = count;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection problem" + ex.Message);
            }

            closeConnection();
            return contador;
        }

    }
}
