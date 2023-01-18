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

namespace AppWindows_Colegio.FormsDocente
{
    public partial class EstadoDocente02 : Form
    {

        ProxyDocente.ServicioDocenteClient objDocente = new ProxyDocente.ServicioDocenteClient();
        ProxyDocente.DocenteBE objDocenteBE = new ProxyDocente.DocenteBE();
        ProxyExtra.IServicioExtraClient objExtra = new ProxyExtra.IServicioExtraClient();


      
        public EstadoDocente02()
        {
            InitializeComponent();

        }

        private String _Codigo;

        public String Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }

        }


        private void btnCargarDoc_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog2.Multiselect = false;
                openFileDialog2.Title = "Seleccione un archivo";
                openFileDialog2.Filter = "Word/PDF Files|*.docx;*.pdf";


                String Texto = openFileDialog2.FileName;

                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = Path.GetFileName(openFileDialog2.FileName);
                    textBox2.Text = Path.GetFullPath(openFileDialog2.FileName);
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
            try
            {

                if (txtComentario.TextLength == 0)
                {
                    throw new Exception("Debe ingresar un comentario");
                }

                String strRutaDoc3 = openFileDialog2.FileName;

                if (strRutaDoc3 == "")
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
                    objDocente.DeleteDocente(Convert.ToInt16(Codigo));
                    MessageBox.Show("Docente habilitado");
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estas seguro que quieres salir?", "Confirmacion", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)

                this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox3.Text = folderBrowserDialog1.SelectedPath.ToString();
        }
    }
}
