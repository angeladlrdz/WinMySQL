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
    public partial class frmMateria : Form
    {
        int id = 0;
        bool updating = false;
        Datos dt = new Datos();
        public frmMateria()
        {
            InitializeComponent();
        }

        //SOBRECARGA DE METODO
        public frmMateria(int id, string materia, string cve)
        {
            InitializeComponent();
            this.id = id;
            txtMateria.Text = materia;
            txtClave.Text = cve;
            updating = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (updating == false)
            {
                bool resultado = dt.ejecutarComando(
                    $"Insert into Materias (Materia,CVE) " +
                    $"values ('{txtMateria.Text}','{txtClave.Text}')");

                if (resultado)
                {
                    MessageBox.Show("Materia agregada correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar la materia");
                }
            }
            else
            {
                bool resultado = dt.ejecutarComando(
                    $"Update Materias set Materia = '{txtMateria.Text}', CVE ='{txtClave.Text}' " +
                    $"where idMaterias = {id}");
                if (resultado)
                {
                    MessageBox.Show("Materia actualizado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar la materia");
                }
            }
        }
    }
}
