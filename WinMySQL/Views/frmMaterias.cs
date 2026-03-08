using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinMySQL.Clases;

namespace WinMySQL.Views
{
    public partial class frmMaterias : Form
    {
        Datos datos = new Datos();
        DataSet ds;
        public frmMaterias()
        {
            InitializeComponent();
        }

        private void frmMaterias_Load(object sender, EventArgs e)
        {

        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmMateria materia = new frmMateria();
            materia.ShowDialog();
        }

        private void frmMaterias_Activated(object sender, EventArgs e)
        {
            try
            {
                ds = datos.ejecutar("SELECT * from Materias");
                if (ds != null)
                {
                    dgvMaterias.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex) { }
        }

        private void dgvMaterias_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMateria materia = new frmMateria(
                Convert.ToInt32(dgvMaterias.CurrentRow.Cells[0].Value),
                dgvMaterias.CurrentRow.Cells[1].Value.ToString(),
                dgvMaterias.CurrentRow.Cells[2].Value.ToString());
            materia.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idMateria = Convert.ToInt32(dgvMaterias.CurrentRow.Cells[0].Value); 
            if(MessageBox.Show("Deseas eliminar la materia: " + dgvMaterias.CurrentRow.Cells[1].Value.ToString(), "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool f = datos.ejecutarComando($"Delete from Materias where idMaterias =" + $"{idMateria}");
                if ( f ) 
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
