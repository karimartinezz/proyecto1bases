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
    public partial class pacienteCitas : Form
    {
        public pacienteCitas()
        {
            InitializeComponent();
        }

        private void registrarCita_Click(object sender, EventArgs e)
        {
            audio_texto audio_texto =new audio_texto();
            this.Hide();
            audio_texto.Show();
            
            
        }

        private void cancelarCita_Click(object sender, EventArgs e)
        {
            cancelarCitaP cancelarCita = new cancelarCitaP();
            this.Hide();
            cancelarCita.Show();
        }
    }
}
