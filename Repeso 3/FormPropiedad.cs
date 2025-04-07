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
    public partial class FormPropiedad : Form
    {
        List<Propiedad> propiedades = new List<Propiedad>();
        List<Propietario> propietarios = new List<Propietario>();
        public FormPropiedad()
        {
            InitializeComponent();
        }
        private void mostrar()
        {
            PropiedadArchivo propiedadArchivo = new PropiedadArchivo();
            propiedades = propiedadArchivo.Leer("../../Propiedades.json");

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = propiedades;
            dataGridView1.Refresh();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Propiedad propiedad = new Propiedad();

            propiedad.dpi = cmbdpi.SelectedValue.ToString();
            propiedad.numero_casa = txtNumero.Text;
            propiedad.cuota = Convert.ToDecimal(maskedTextBox1.Text);

            propiedades.Add(propiedad);

            PropiedadArchivo propiedadArchivo = new PropiedadArchivo();
            propiedadArchivo.Guardar("../../Propiedades.json", propiedades);

            txtNumero.Clear();
            maskedTextBox1.Clear();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            mostrar();
        }

        private void btnPropietarios_Click(object sender, EventArgs e)
        {
            FormPropietario formPropietario = new FormPropietario();
            formPropietario.Show();
            this.Close();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            FormReporte formReporte = new FormReporte();
            formReporte.Show();
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
