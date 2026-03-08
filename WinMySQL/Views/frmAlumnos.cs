using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinMySQL.Clases;

namespace WinMySQL.Views
{
    public partial class frmAlumnos : Form
    {
        Datos datos = new Datos();
        DataSet ds;
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAlumno alumno = new frmAlumno();
            alumno.ShowDialog();
        }

        private void frmAlumnos_Activated(object sender, EventArgs e)
        {
            try
            {
                ds = datos.ejecutar("SELECT * from Alumnos");
                if (ds != null)
                {
                    dgvAlumnos.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex) { }
        }

        private void dgvAlumnos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmAlumno alumno = new frmAlumno(
                Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[0].Value),
                dgvAlumnos.CurrentRow.Cells[1].Value.ToString(),
                dgvAlumnos.CurrentRow.Cells[2].Value.ToString(),
                dgvAlumnos.CurrentRow.Cells[3].Value.ToString(),
                dgvAlumnos.CurrentRow.Cells[4].Value.ToString(),
                dgvAlumnos.CurrentRow.Cells[5].Value.ToString(),
                dgvAlumnos.CurrentRow.Cells[6].Value.ToString(),
                dgvAlumnos.CurrentRow.Cells[7].Value.ToString());
            alumno.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idAlumnos = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[0].Value);
            if (MessageBox.Show("Deseas eliminar al alumno: " + dgvAlumnos.CurrentRow.Cells[2].Value.ToString() + " " + dgvAlumnos.CurrentRow.Cells[3].Value.ToString() + " " + dgvAlumnos.CurrentRow.Cells[4].Value.ToString(), "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool f = datos.ejecutarComando($"Delete from Alumnos where idAlumnos =" + $"{idAlumnos}");
                if (f)
                {
                    MessageBox.Show("Registro Eliminado", "Sistema");
                }
                else
                {
                    MessageBox.Show("Error", "Sistema");
                }
            }
        }
    }
}
