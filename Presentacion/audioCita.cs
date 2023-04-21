using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Speech.Recognition;
using Logica;
using System.Text.RegularExpressions;

namespace Presentacion
{
    public partial class audioCita : Form
    {
        private SpeechRecognitionEngine recognizer;
        Logica.citas citas = new Logica.citas();
        public audioCita()
        {
            InitializeComponent();
            recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("es-ES"));
            recognizer.LoadGrammar(new DictationGrammar());
            recognizer.SetInputToDefaultAudioDevice();
            recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);
        }
         string area;
         string observaciones;
         string cedulaPaciente;
        private void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            // Procesa el texto reconocido
            string textoReconocido = e.Result.Text;
            Console.WriteLine("Texto reconocido: " + textoReconocido);
            // Busca las palabras clave en el texto reconocido y las guarda en las variables correspondientes
            if (textoReconocido.Contains("área"))
            {
                area = textoReconocido.Replace("area", "").Trim();
                Console.WriteLine("Área: " + area);
            }
            else if (textoReconocido.Contains("observaciones"))
            {
                observaciones = textoReconocido.Replace("observaciones", "").Trim();
                Console.WriteLine("Observaciones: " + observaciones);
            }
            else if (textoReconocido.Contains("cédula"))
            {
                cedulaPaciente = textoReconocido.Replace("cédula", "").Trim();
                cedulaPaciente=cedulaPaciente.Replace(" ", "");
                cedulaPaciente=Regex.Replace(cedulaPaciente, "[^0-9]", "");
                Console.WriteLine("cédula: " + cedulaPaciente);
            }
        }

        private void empezar_Click(object sender, EventArgs e)
        {
            pausa.Enabled = true;
            recognizer.RecognizeAsync(RecognizeMode.Multiple);
            Console.WriteLine("Recording...");
        }

        private void pausa_Click(object sender, EventArgs e)
        {
            recognizer.RecognizeAsyncStop();
            Console.WriteLine("Recording stopped.");
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            
            
            int validar = citas.revisarPaciente(Int32.Parse(cedulaPaciente));
            
            if (validar == 0)
            {
                MessageBox.Show("La cedula del paciente no está registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DateTime fechaHoraSeleccionada = dateTimePicker1.Value;

                string fechaSeleccionada = fechaHoraSeleccionada.Date.ToString("yyyy-MM-dd");

                TimeSpan horaSeleccionada = fechaHoraSeleccionada.TimeOfDay;
               
                
                   citas.registrarCitaPaciente(observaciones, area, fechaSeleccionada, horaSeleccionada, Int32.Parse(cedulaPaciente));

                


            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
