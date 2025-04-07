using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repeso_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPropietario_Click(object sender, EventArgs e)
        {
            FormPropietario formPropietario = new FormPropietario();
            formPropietario.Show();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            FormReporte formReporte = new FormReporte();
            formReporte.Show();
        }

        private void btnPropiedad_Click(object sender, EventArgs e)
        {
            FormPropiedad formPropiedad = new FormPropiedad();
            formPropiedad.Show();
        }
    }
}
