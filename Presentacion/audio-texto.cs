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
    public partial class audio_texto : Form
    {
        public audio_texto()
        {
            InitializeComponent();
        }

        private void audio_texto_Load(object sender, EventArgs e)
        {

        }

        private void texto_Click(object sender, EventArgs e)
        {

            registrarCita registrarCita = new registrarCita();
            this.Hide();
            registrarCita.Show();
        }

        private void btnAudio_Click(object sender, EventArgs e)
        {
            audioCita audioCita = new audioCita();
            this.Hide();
            audioCita.Show();
        }
    }
}
