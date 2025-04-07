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
    
    public partial class FormPropietario : Form
    {
        List<Propietario> propietarios = new List<Propietario>();
        public FormPropietario()
        {
            InitializeComponent();
        }
        public void mostrar()
        {
            PropietarioArchivo propietarioArchivo = new PropietarioArchivo();
            propietarios = propietarioArchivo.Leer("../../Propietarios.json");

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = propietarios;
            dataGridView1.Refresh();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Propietario propietario = new Propietario();

            propietario.dpi = txtdpi.Text;
            propietario.nombre = txtNombre.Text;
            propietario.apellido = txtApellido.Text;

            propietarios.Add(propietario);

            PropietarioArchivo propietarioArchivo = new PropietarioArchivo();
            propietarioArchivo.Guardar("../../Propietarios.json", propietarios);

            txtdpi.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
        }

        private void btnPropiedad_Click(object sender, EventArgs e)
        {
            FormPropiedad formPropiedad = new FormPropiedad();
            formPropiedad.Show();
            this.Close();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            FormReporte formReporte = new FormReporte();
            formReporte.Show();
            this.Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            mostrar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
