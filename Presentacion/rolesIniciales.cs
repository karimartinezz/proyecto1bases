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
    public partial class rolesIniciales : Form
    {
        public rolesIniciales()
        {
            InitializeComponent();
        }

        private void funcionario_Click(object sender, EventArgs e)
        {
            funcionarioCitas funcionarioCitas = new funcionarioCitas();
            this.Hide();
            funcionarioCitas.Show();
        }

        private void paciente_Click(object sender, EventArgs e)
        {
            pacienteCitas Citas = new pacienteCitas();
            this.Hide();
            Citas.Show();
        }
    }
}
