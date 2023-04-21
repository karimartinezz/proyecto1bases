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
    public partial class funcionarioCitas : Form
    {
        public funcionarioCitas()
        {
            InitializeComponent();
        }

        private void reasignacionCita_Click(object sender, EventArgs e)
        {
            reasignacionCita reasignacionCita = new reasignacionCita();
            this.Hide();
            reasignacionCita.Show();
        }

        private void cancelarCita_Click(object sender, EventArgs e)
        {
            cancelarCitaF cancelarCitaF = new cancelarCitaF();
            this.Hide();
            cancelarCitaF.Show();
        }

       
    }
}
