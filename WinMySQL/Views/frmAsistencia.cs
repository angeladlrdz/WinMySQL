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

        private void busqueda()
        {
            DataSet ds = datos.ejecutar($"Select nocontrol from Asistencia");
            if (ds != null)
            {
                dgvAsistencia.DataSource = ds.Tables[0];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (dtpAsistencia.Value.Date > DateTime.Today)
            {
                MessageBox.Show("No puede pasar lista de una fecha futura", "Sistema");
                return;
            }

            string comando = $"UPDATE Asistencia SET asistencia = {1} WHERE nocontrol = '{txtAsistencia.Text}' AND fecha = '{dtpAsistencia.Value.ToString("yyyy-MM-dd")}'";
            datos.ejecutarComando(comando);

            actualizarDgv2();
            MessageBox.Show("Asistencia actualizada", "Sistema");

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (dtpAsistencia.Value.Date > DateTime.Today)
            {
                MessageBox.Show("No puede pasar lista de una fecha futura", "Sistema");
                return;
            }

            string comando = $"UPDATE Asistencia SET asistencia = {0} WHERE nocontrol = '{txtAsistencia.Text}' AND fecha = '{dtpAsistencia.Value.ToString("yyyy-MM-dd")}'";
            datos.ejecutarComando(comando);

            actualizarDgv2();
            MessageBox.Show("Asistencia actualizada", "Sistema");

        }

        private void frmAsistencia_Load(object sender, EventArgs e)
        {

            busqueda();
            for (int i = 0; i < dgvAsistencia.Rows.Count - 1; i++)
            {
                string noControl = dgvAsistencia.Rows[i].Cells[0].Value?.ToString();
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
            // Insertar alumnos con default 0 si no existen en esa fecha
            for (int i = 0; i < dgvAsistencia.Rows.Count - 1; i++)
            {
                string noControl = dgvAsistencia.Rows[i].Cells[0].Value?.ToString();
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
            DataSet ds = datos.ejecutar($"SELECT a.nocontrol, CONCAT(al.nombre, ' ', al.paterno, ' ', al.materno) AS nombre_completo, a.fecha, a.asistencia FROM Asistencia a INNER JOIN Alumnos al ON a.nocontrol = al.nocontrol WHERE a.nocontrol LIKE '{txtAsistencia.Text}%' ORDER BY a.fecha DESC");
            if (ds != null)
            {
                dgvAsistencia.DataSource = ds.Tables[0];
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataSet ds = datos.ejecutar($"SELECT a.nocontrol, CONCAT(al.nombre, ' ', al.paterno, ' ', al.materno) AS nombre, a.asistencia FROM Asistencia a INNER JOIN Alumnos al ON a.nocontrol = al.nocontrol WHERE a.fecha = '{dtpAsistencia.Value.ToString("yyyy-MM-dd")}'");
            if (ds != null)
                dgvAsistencia.DataSource = ds.Tables[0];
        }
    }
}
