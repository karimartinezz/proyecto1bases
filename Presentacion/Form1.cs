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


namespace Presentacion
{
    public partial class Form1 : Form
    {
        Logica.citas citas=new Logica.citas();
        public Form1()
        {
            InitializeComponent();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }
        private void registrar_Click(object sender, EventArgs e)
        {
            DateTime fechaHoraSeleccionada = dateTimePicker1.Value;
            
            string fechaSeleccionada = fechaHoraSeleccionada.Date.ToString("yyyy-MM-dd");
   
            TimeSpan horaSeleccionada = fechaHoraSeleccionada.TimeOfDay;
            
            citas.registrarCita(observaciones.Text, area.Text, fechaSeleccionada, horaSeleccionada);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
