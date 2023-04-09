using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    public class citas
    {
        Datos.ConexionBD conexion = new Datos.ConexionBD();

       
        public void registrarCita(string observaciones, string area, string fechaSeleccionada, TimeSpan horaSeleccionada)
        {
           
            string estado = "Registrada";
            int id = conexion.generarID("Cita" , "ID");
            conexion.registrarCitaDAO(id, observaciones, area, horaSeleccionada, fechaSeleccionada,  estado);



        }

    }
}
