using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinMySQL.Clases;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinMySQL.Views
{
    public partial class frmBusqueda : Form
    {
        Datos datos = new Datos();
        DataSet ds;
        public frmBusqueda()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string texto = txtBusqueda.Text.Trim();
            if (string.IsNullOrWhiteSpace(texto))
            {
                actualizarDgv2();
                return;
            }

            string consulta = $@"SELECT a.nocontrol, CONCAT(al.nombre, ' ', al.paterno, ' ', al.materno) AS nombre_completo,
                            a.fecha, a.asistencia FROM Asistencia a INNER JOIN Alumnos al ON a.nocontrol = al.nocontrol
                            WHERE al.nombre LIKE '{texto}%' OR al.paterno LIKE '{texto}%' OR al.materno LIKE '{texto}%'
                            OR a.nocontrol LIKE '{texto}%' ORDER BY a.fecha DESC";

            DataSet ds = datos.ejecutar(consulta);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                dgvBusqueda.DataSource = ds.Tables[0];
                lblAsistio.Text = "";
                lblNoAsistio.Text = "";
            }
            else
            {
                MessageBox.Show("No se encontraron resultados", "Sistema");
            }
        }
        private void frmBusqueda_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvBusqueda.Rows.Count - 1; i++)
            {
                string noControl = dgvBusqueda.Rows[i].Cells[0].Value?.ToString();
                DataSet dsVerifica = datos.ejecutar($"SELECT * FROM Asistencia WHERE nocontrol = '{noControl}' AND fecha = '{DateTime.Today.ToString("yyyy-MM-dd")}'");

            }
            actualizarDgv2();
        }

        private void actualizarDgv2()
        {
            string fecha = dtpBusqueda.Value.ToString("yyyy-MM-dd");

            string consulta = $@"SELECT a.nocontrol, CONCAT(al.nombre, ' ', al.paterno, ' ', al.materno) AS nombre_completo, a.fecha,
                    a.asistencia, SUM(CASE WHEN a.asistencia = 1 THEN 1 ELSE 0 END) OVER() AS total_si, SUM(CASE WHEN a.asistencia = 0 THEN 1 ELSE 0 END) OVER() AS total_no
                    FROM Asistencia a INNER JOIN Alumnos al ON a.nocontrol = al.nocontrol WHERE a.fecha = '{fecha}' ORDER BY a.asistencia DESC";

            DataSet ds = datos.ejecutar(consulta);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                dgvBusqueda.DataSource = ds.Tables[0];

                // Ocultar columnas del grid
                dgvBusqueda.Columns["total_si"].Visible = false;
                dgvBusqueda.Columns["total_no"].Visible = false;

                // Mostrar en labels
                int totalSi = Convert.ToInt32(ds.Tables[0].Rows[0]["total_si"]);
                int totalNo = Convert.ToInt32(ds.Tables[0].Rows[0]["total_no"]);
                lblAsistio.Text = $"Asistieron: {totalSi}";
                lblNoAsistio.Text = $"Faltaron: {totalNo}";
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string fecha = dtpBusqueda.Value.ToString("yyyy-MM-dd");

            string consulta = $@"SELECT a.nocontrol, CONCAT(al.nombre, ' ', al.paterno, ' ', al.materno) AS nombre_completo, a.fecha,
                            a.asistencia, SUM(CASE WHEN a.asistencia = 1 THEN 1 ELSE 0 END) OVER() AS total_si, SUM(CASE WHEN a.asistencia = 0 THEN 1 ELSE 0 END) OVER() AS total_no
                            FROM Asistencia a INNER JOIN Alumnos al ON a.nocontrol = al.nocontrol WHERE a.fecha = '{fecha}' ORDER BY a.asistencia DESC";

            DataSet ds = datos.ejecutar(consulta);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                dgvBusqueda.DataSource = ds.Tables[0];
                int totalSi = Convert.ToInt32(ds.Tables[0].Rows[0]["total_si"]);
                int totalNo = Convert.ToInt32(ds.Tables[0].Rows[0]["total_no"]);
                lblAsistio.Text = $"Asistieron: {totalSi}";
                lblNoAsistio.Text = $"Faltaron: {totalNo}";
            }
            else
            {
                MessageBox.Show("No hay registros para esa fecha", "Sistema");
                lblAsistio.Text = "";
                lblNoAsistio.Text = "";
            }
        }
    }
}
