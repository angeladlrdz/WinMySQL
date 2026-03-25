using FastReport.Editor.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinMySQL.Clases;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinMySQL.Views
{
    public partial class frmAsistencia : Form
    {
        Datos datos = new Datos();
        DataSet ds;
        public frmAsistencia()
        {
            InitializeComponent();
        }

        private void frmAsistencia_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvAsistencia.Rows.Count - 1; i++)
            {
                string noControl = Convert.ToString(dgvAsistencia.Rows[i].Cells[0].Value);
                DataSet dsVerifica = datos.ejecutar($"SELECT * FROM Asistencia WHERE nocontrol = '{noControl}' AND fecha = '{DateTime.Today.ToString("yyyy-MM-dd")}'");
                if (dsVerifica.Tables[0].Rows.Count == 0)
                {
                    string comando = $"INSERT INTO Asistencia (fecha, asistencia, nocontrol) VALUES ('{DateTime.Today.ToString("yyyy-MM-dd")}', 0, '{noControl}')";
                    datos.ejecutarComando(comando);
                }
            }
            actualizarDgv2();
        }

        private void actualizarDgv2()
        {
            DataSet ds = datos.ejecutar($"SELECT a.nocontrol, CONCAT(al.nombre, ' ', al.paterno, ' ', al.materno) AS nombre, a.asistencia FROM Asistencia a INNER JOIN Alumnos al ON a.nocontrol = al.nocontrol WHERE a.fecha = '{dtpAsistencia.Value.ToString("yyyy-MM-dd")}'");
            if (ds != null)
                dgvAsistencia.DataSource = ds.Tables[0];
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvAsistencia.Rows.Count - 1; i++)
            {
                string noControl = Convert.ToString(dgvAsistencia.Rows[i].Cells[0].Value);
                DataSet dsVerifica = datos.ejecutar($"SELECT * FROM Asistencia WHERE nocontrol = '{noControl}' AND fecha = '{dtpAsistencia.Value.ToString("yyyy-MM-dd")}'");
                if (dsVerifica.Tables[0].Rows.Count == 0)
                {
                    string comando = $"INSERT INTO Asistencia (fecha, asistencia, nocontrol) VALUES ('{dtpAsistencia.Value.ToString("yyyy-MM-dd")}', 0, '{noControl}')";
                    datos.ejecutarComando(comando);
                }
            }
            actualizarDgv2();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string valor = "";
            if (e.RowIndex >= 0)
            {
                valor = dgvAsistencia.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }

            txtAsistencia.Text = valor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBusqueda busqueda = new frmBusqueda();
            busqueda.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataSet ds = datos.ejecutar($"SELECT a.nocontrol, CONCAT(al.nombre, ' ', al.paterno, ' ', al.materno) AS nombre, a.asistencia FROM Asistencia a INNER JOIN Alumnos al ON a.nocontrol = al.nocontrol WHERE a.fecha = '{dtpAsistencia.Value.ToString("yyyy-MM-dd")}'");
            if (ds != null)
                dgvAsistencia.DataSource = ds.Tables[0];
            else
            {
                MessageBox.Show("No se encontraron resultados", "Sistema");
                actualizarDgv2();
            }
        }

        private void txtAsistencia_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtAsistencia.Text)) return;

                if (dtpAsistencia.Value.Date > DateTime.Today)
                {
                    MessageBox.Show("No puede pasar lista de una fecha futura", "Sistema");
                    return;
                }

                DataSet dsActual = datos.ejecutar($"SELECT asistencia FROM Asistencia WHERE nocontrol = '{txtAsistencia.Text}' AND fecha = '{dtpAsistencia.Value.ToString("yyyy-MM-dd")}'");

                if (dsActual == null || dsActual.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró el número de control para esa fecha", "Sistema");
                    return;
                }

                int valorActual = Convert.ToInt32(dsActual.Tables[0].Rows[0]["asistencia"]);
                int nuevoValor = (valorActual == 1) ? 0 : 1; // Toggle

                string comando = $"UPDATE Asistencia SET asistencia = {nuevoValor} WHERE nocontrol = '{txtAsistencia.Text}' AND fecha = '{dtpAsistencia.Value.ToString("yyyy-MM-dd")}'";
                datos.ejecutarComando(comando);
                actualizarDgv2();
            }
        }
    }
}
