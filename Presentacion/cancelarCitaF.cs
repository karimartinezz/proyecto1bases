using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class cancelarCitaF : Form
    {
        Logica.citas citas = new Logica.citas();
        public cancelarCitaF()
        {
            InitializeComponent();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            int validar1 = citas.revisarFuncionario(Int32.Parse(cedulaFuncionario.Text));

            int validar2= citas.revisarPaciente(Int32.Parse(cedula.Text));

            DateTime fechaHoraSeleccionada = dateTimePicker1.Value;

            string fechaSeleccionada = fechaHoraSeleccionada.Date.ToString("yyyy-MM-dd");

            TimeSpan horaSeleccionada = fechaHoraSeleccionada.TimeOfDay;

            int IDencontrado = citas.revisarCita(Int32.Parse(cedula.Text), fechaSeleccionada, horaSeleccionada);

            if (validar2 == 0)
            {
                MessageBox.Show("El paciente no está registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (validar1 == 0)
            {
                MessageBox.Show("El funcionario no está registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (IDencontrado == -1)
            {
                MessageBox.Show("La cita ingresada no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (IDencontrado == -2)
            {
                MessageBox.Show("No se puede cancelar la cita, esta tuvo que haber sido cancelada al menos un día antes de la fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                citas.cancelarCitaCentro(IDencontrado, Int32.Parse(cedulaFuncionario.Text));
            }
        }
    }
}
