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
    public partial class frmProfesor : Form
    {
        int id = 0;
        bool updating = false;
        Datos dt = new Datos();
        public frmProfesor()
        {
            InitializeComponent();
        }
        public frmProfesor(int id, string numEmpleado, string nombre, string segNombre, string apellidoPat, string apellidoMat, string RFC, string grado)
        {
            InitializeComponent();
            this.id = id;
            txtNumEmpleado.Text = numEmpleado;
            txtNombre.Text = nombre;
            txtSegNombre.Text = segNombre;
            txtApPaterno.Text = apellidoPat;
            txtApMaterno.Text = apellidoMat;
            txtRFC.Text = RFC;
            txtGrado.Text = grado;
            updating = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (updating == false)
            {
                bool resultado = dt.ejecutarComando(
                    $"Insert into Profesores (NumEmpleado, PrimerNombre, SegundoNombre, ApellidoPaterno, ApellidoMaterno, RFC, GradoAcademico) " +
                    $"values ('{txtNumEmpleado.Text}','{txtNombre.Text}','{txtSegNombre.Text}','{txtApPaterno.Text}','{txtApMaterno.Text}'," +
                    $"'{txtRFC.Text}','{txtGrado.Text}')");

                if (resultado)
                {
                    MessageBox.Show("Profesor agregado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar Profesor");
                }
            }
            else
            {
                bool resultado = dt.ejecutarComando(
                    $"Update Profesores set NumEmpleado = '{txtNumEmpleado.Text}', PrimerNombre ='{txtNombre.Text}', SegundoNombre = '{txtSegNombre.Text}'," +
                    $"ApellidoPaterno = '{txtApPaterno.Text}', ApellidoMaterno ='{txtApMaterno.Text}', RFC = '{txtRFC.Text}'," +
                    $"GradoAcademico ='{txtGrado.Text}' " + $"where idProfesores = {id}");
                if (resultado)
                {
                    MessageBox.Show("Profesor actualizado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar Profesor");
                }
            }
        }
    }
}
