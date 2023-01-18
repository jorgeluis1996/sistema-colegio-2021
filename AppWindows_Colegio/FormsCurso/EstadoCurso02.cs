using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AppWindows_Colegio.FormsCurso
{
    public partial class EstadoCurso02 : Form
    {
        ProxyCurso.ServicioCursoClient objCurso = new ProxyCurso.ServicioCursoClient();
        public EstadoCurso02()
        {
            InitializeComponent();
        }

        private String _Codigo;

        public String Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtComentario.TextLength == 0)
                {
                    throw new Exception("Debe ingresar un comentario");
                }

                String strRutaDoc2 = openFileDialog1.FileName;

                if (strRutaDoc2 == "")
                {
                    throw new Exception("Debe seleccionar un archivo");
                }

                if (File.Exists(textBox3.Text + "\\" + textBox1.Text))
                {
                    MessageBox.Show("El archivo ya existe");
                }

                else
                {
                    File.Copy(textBox2.Text, textBox3.Text + "\\" + textBox1.Text);
                    objCurso.DeleteCurso(Convert.ToInt16(Codigo));
                    MessageBox.Show("Curso Habilitado");
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargarDoc_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Multiselect = false;
                openFileDialog1.Title = "Seleccione un archivo";
                openFileDialog1.Filter = "Word/PDF Files|*.docx;*.pdf";
                String Texto = openFileDialog1.FileName;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = Path.GetFileName(openFileDialog1.FileName);
                    textBox2.Text = Path.GetFullPath(openFileDialog1.FileName);
                }

                else
                {
                    MessageBox.Show("Por favor, seleccione un archivo");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox3.Text = folderBrowserDialog1.SelectedPath.ToString();
        }
    }
}
