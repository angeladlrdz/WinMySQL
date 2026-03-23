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
        public frmAlumno(int numControl, string nombre, string paterno, string materno)
        {
            InitializeComponent();
            txtNumControl.Text = numControl + "";
            txtNombre.Text = nombre;
            txtApPaterno.Text = paterno;
            txtApMaterno.Text = materno;
            
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
                    $"Insert into Alumnos (nocontrol, nombre, paterno, materno) " +
                    $"values ('{txtNumControl.Text}','{txtNombre.Text}','{txtApPaterno.Text}','{txtApMaterno.Text}')");

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
                    $"Update Alumnos set nombre ='{txtNombre.Text}', paterno = '{txtApPaterno.Text}', materno ='{txtApMaterno.Text}' where nocontrol = '{txtNumControl.Text}'");
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
