using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Presentacion
{
    public partial class registrarCita : Form
    {
        Logica.citas citas=new Logica.citas();
        public registrarCita()
        {
            InitializeComponent();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }
        private void registrar_Click(object sender, EventArgs e)
        {
            int number2, validar=-5;
            if (int.TryParse(cedula.Text, out number2))
            {
                 validar = citas.revisarPaciente(Int32.Parse(cedula.Text));

            }
            else
            {
                MessageBox.Show("La cedula debe ser solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
 
            if (validar == 0)
            {
                MessageBox.Show("La cedula del paciente no está registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DateTime fechaHoraSeleccionada = dateTimePicker1.Value;

                string fechaSeleccionada = fechaHoraSeleccionada.Date.ToString("yyyy-MM-dd");

                TimeSpan horaSeleccionada = fechaHoraSeleccionada.TimeOfDay;
                int number;
                if (int.TryParse(cedula.Text, out number))
                {
                    citas.registrarCitaPaciente(observaciones.Text, area.Text, fechaSeleccionada, horaSeleccionada, Int32.Parse(cedula.Text));
                    
                }
               
                
            }

           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void area_TextChanged(object sender, EventArgs e)
        {

        }

        private void devolverse_Click_1(object sender, EventArgs e)
        {
            pacienteCitas Citas = new pacienteCitas();
            this.Hide();
            Citas.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void observaciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void cedulaRegistrador_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
