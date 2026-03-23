using OfficeOpenXml;
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
            //String path;
            //DialogResult dr = ofdExcel.ShowDialog();
            //if (dr == DialogResult.OK)
            //{
            //    path = ofdExcel.FileName;
            //    //IMPORTAR LA INFOMRMACION
            //    ExcelPackage.License.SetNonCommercialPersonal("Luis Mota");
            //    using (var package = new ExcelPackage(new FileInfo(path)))
            //    {
            //        ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
            //        int rowCount = worksheet.Dimension.Rows;
            //        int colCount = worksheet.Dimension.Columns;

            //        //EN LA MEMORIA
            //        DataTable dt = new DataTable();
            //        for (int col = 1; col <= colCount; col++)
            //        {
            //            dt.Columns.Add(worksheet.Cells[1, col].Value.ToString());
            //        }
            //        for (int row = 2; row <= rowCount; row++) //DESDE EL 2 PORQUE EL PRIMERO TIENE LOS TITULOS DE LAS COLUMNAS
            //        {
            //            DataRow drNew = dt.NewRow();
            //            for (int col = 1; col <= colCount; col++)
            //            {
            //                drNew[col - 1] = worksheet.Cells[row, col].Value.ToString();//TRAERNOS EL VALOR DE CADA CELDA
            //            }
            //            dt.Rows.Add(drNew); //CUANDO TENGO TODOS LOS DATOS DEL RENGLOS YA LO AÑADE
            //            String comando = $"Insert into Alumnos(nocontrol, nombre, paterno, materno) Values" +
            //                $" ('{drNew.ItemArray[0]}','{drNew.ItemArray[1]}','{drNew.ItemArray[2]}','{drNew.ItemArray[3]}')";
            //            datos.ejecutarComando(comando);
            //        }
            //    }


            //}

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
                dgvAlumnos.CurrentRow.Cells[3].Value.ToString());
            alumno.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idAlumnos = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[0].Value);
            if (MessageBox.Show("Deseas eliminar al alumno: " + dgvAlumnos.CurrentRow.Cells[1].Value.ToString() + " " + dgvAlumnos.CurrentRow.Cells[2].Value.ToString() + " " + dgvAlumnos.CurrentRow.Cells[3].Value.ToString(), "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            Busqueda();
        }

        private void txtAlumno_TextChanged(object sender, EventArgs e)
        {
            Busqueda();
        }

        private void Busqueda()
        {
            DataSet ds = datos.ejecutar($"Select nocontrol, nombre, paterno, materno from Alumnos where nombre like '{txtAlumno.Text}%'");
            if (ds != null)
            {
                dgvAlumnos.DataSource = ds.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAsistencia asistencia = new frmAsistencia();
            asistencia.ShowDialog();
        }
    }
}
