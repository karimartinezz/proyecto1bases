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

       
        public void registrarCita(string observaciones, string area, string fechaSeleccionada, TimeSpan horaSeleccionada, int cedula)
        {
           
            string estado = "Registrada";
            int id = conexion.generarID("Cita" , "ID");
            conexion.registrarCitaDAO(id, observaciones, area, horaSeleccionada, fechaSeleccionada,  estado, cedula);

        }
        public int revisarPaciente(int cedula)
        {
            int validar=conexion.validarExistenciaPaciente(cedula);
            return validar;

        }
        public int revisarCita(int cedula, string fechaSeleccionada, TimeSpan horaSeleccionada) {
            int validar=conexion.validarPacienteCita( cedula,  fechaSeleccionada,  horaSeleccionada);
            return validar;
        }
        public void cancelarCita(int ID)
        {
            string estado = "Cancelada por paciente";
            conexion.cancelarCitaDAO(ID, estado);

        }
        public void cancelarCitaCentro(int ID)
        {
            string estado = "Cancelada por centro medico";
            conexion.cancelarCitaDAO(ID, estado);

        }

    }
}
