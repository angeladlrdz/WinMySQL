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
    public partial class frmAlumno : Form
    {
        int id = 0;
        bool updating = false;
        Datos dt = new Datos();
        public frmAlumno()
        {
            InitializeComponent();
        }
        public frmAlumno(int id, string numControl, string nombre, string segNombre, string apellidoPat, string apellidoMat, string carrera, string correo)
        {
            InitializeComponent();
            this.id = id;
            txtNumControl.Text = numControl;
            txtNombre.Text = nombre;
            txtSegNombre.Text = segNombre;
            txtApPaterno.Text = apellidoPat;
            txtApMaterno.Text = apellidoMat;
            txtCarrera.Text = carrera;
            txtCorreo.Text = correo;
            updating = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (updating == false)
            {
                bool resultado = dt.ejecutarComando(
                    $"Insert into Alumnos (NumControl,PrimerNombre, SegundoNombre, ApellidoPaterno, ApellidoMaterno, Carrera, Email) " +
                    $"values ('{txtNumControl.Text}','{txtNombre.Text}','{txtSegNombre.Text}','{txtApPaterno.Text}','{txtApMaterno.Text}'," +
                    $"'{txtCarrera.Text}','{txtCorreo.Text}')");

                if (resultado)
                {
                    MessageBox.Show("Alumno agregado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar Alumno");
                }
            }
            else
            {
                bool resultado = dt.ejecutarComando(
                    $"Update Alumnos set NumControl = '{txtNumControl.Text}', PrimerNombre ='{txtNombre.Text}', SegundoNombre = '{txtSegNombre.Text}'," +
                    $"ApellidoPaterno = '{txtApPaterno.Text}', ApellidoMaterno ='{txtApMaterno.Text}', Carrera = '{txtCarrera.Text}'," +
                    $"Email ='{txtCorreo.Text}' " + $"where idAlumnos = {id}");
                if (resultado)
                {
                    MessageBox.Show("Alumno actualizado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar Alumno");
                }
            }
        }
    }
    
}
