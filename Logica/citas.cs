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


        public void registrarCitaPaciente(string observaciones, string area, string fechaSeleccionada, TimeSpan horaSeleccionada, int cedula)
        {

            string estado = "Registrada";
            int id = conexion.generarID("Cita", "ID");

            TimeSpan horaActual = DateTime.Now.TimeOfDay;
            DateTime fecha = DateTime.Today;
            string fechaActual = fecha.Date.ToString("yyyy-MM-dd");
            conexion.registrarCitaDAO(id, observaciones, area, horaSeleccionada, fechaSeleccionada, estado, cedula);
            conexion.bitacoraPaciente(id, cedula, estado, fechaActual, horaActual); ;
        }
        public int revisarPaciente(int cedula)
        {
            int validar = conexion.validarExistenciaPaciente(cedula);
            return validar;

        }
        public int revisarCita(int cedula, string fechaSeleccionada, TimeSpan horaSeleccionada)
        {
            int validar = conexion.validarPacienteCita(cedula, fechaSeleccionada, horaSeleccionada);
            return validar;
        }
        public void cancelarCita(int ID, int cedula)
        {
            string estado = "Cancelada por paciente";
            conexion.modificarEstadoCita(ID, estado);
            TimeSpan horaActual = DateTime.Now.TimeOfDay;
            DateTime fecha = DateTime.Today;
            string fechaActual = fecha.Date.ToString("yyyy-MM-dd");
            conexion.bitacoraPaciente(ID, cedula, estado, fechaActual, horaActual);

        }
        public void cancelarCitaCentro(int ID, int cedula)
        {
            string estado = "Cancelada por centro medico";
            conexion.modificarEstadoCita(ID, estado);
            TimeSpan horaActual = DateTime.Now.TimeOfDay;
            DateTime fecha = DateTime.Today;
            string fechaActual = fecha.Date.ToString("yyyy-MM-dd");
            conexion.bitacoraFuncionario(ID, cedula, estado, fechaActual, horaActual);

        }
        public int revisarFuncionario(int cedula)
        {
            int validar = conexion.validarExistenciaFuncionario(cedula);
            return validar;

        }
        public int revisarEstado(int id)
        {
            int validar = conexion.validarCancelacionCentro(id);
            return validar;
        }
        public void asignarCita(int ID, int cedula)
        {
            string estado = "Asignada";
            conexion.modificarEstadoCita(ID, estado);
            TimeSpan horaActual = DateTime.Now.TimeOfDay;
            DateTime fecha = DateTime.Today;
            string fechaActual = fecha.Date.ToString("yyyy-MM-dd");
            conexion.bitacoraFuncionario(ID, cedula, estado, fechaActual, horaActual);



        }
    }
}
