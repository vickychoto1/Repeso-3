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
    public partial class FormReporte : Form
    {
        List<Reporte> reportes = new List<Reporte>();
        List<Propietario> propietarios = new List<Propietario>();
        List<Propiedad> propiedades = new List<Propiedad>();
        public FormReporte()
        {
            InitializeComponent();
        }

        private void FormReporte_Load(object sender, EventArgs e)
        {
            PropietarioArchivo propietarioArchivo = new PropietarioArchivo();
            propietarios = propietarioArchivo.Leer("../../Propietarios.json");

            PropiedadArchivo propiedadArchivo = new PropiedadArchivo();
            propiedades = propiedadArchivo.Leer("../../Propiedades.json");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var mayor = reportes.OrderByDescending(r => r.cuota).FirstOrDefault();

            if (mayor != null)
            {

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = new List<Reporte> { mayor };
                dataGridView1.Refresh();
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            foreach (var propietario in propietarios)
            {
                foreach (var propiedad in propiedades)
                {
                    if (propietario.dpi == propiedad.dpi.Trim())

                    {
                        Reporte reporte = new Reporte();
                        reporte.dpi = propiedad.dpi;
                        reporte.nombre = propietario.nombre;
                        reporte.apellido = propietario.apellido;
                        reporte.numero_casa = propiedad.numero_casa;
                        reporte.cuota = propiedad.cuota;

                        reportes.Add(reporte);

                    }
                }
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = reportes;
            dataGridView1.Refresh();
        }

        private void btnOrdenCuota_Click(object sender, EventArgs e)
        {
            var ordenados = reportes.OrderByDescending(r => r.cuota).ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ordenados;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ordenados = reportes.OrderBy(r => r.cuota).ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ordenados;
            dataGridView1.Refresh();
        }

        private void btnAltosBajos_Click(object sender, EventArgs e)
        {
            var topAltas = reportes.OrderByDescending(r => r.cuota).Take(3);
            var topBajas = reportes.OrderBy(r => r.cuota).Take(3);

            var topCombinado = topAltas.Concat(topBajas).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = topCombinado;
            dataGridView1.Refresh();
        }
    }
}
