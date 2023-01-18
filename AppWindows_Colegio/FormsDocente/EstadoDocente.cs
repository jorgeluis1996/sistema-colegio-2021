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
    public partial class EstadoDocente : Form
    {
        ProxyDocente.ServicioDocenteClient objDocente = new ProxyDocente.ServicioDocenteClient();
        ProxyDocente.DocenteBE objDocenteBE = new ProxyDocente.DocenteBE();
        ProxyExtra.IServicioExtraClient objExtra = new ProxyExtra.IServicioExtraClient();

        public EstadoDocente()
        {
            InitializeComponent();
        }

        private String _Codigo;

        public String Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSeleccione_Click(object sender, EventArgs e)
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estas seguro que quieres enviar el siguiente informe ?", "Confirmacion", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {

                try

                {
                    if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false)

                    {
                        throw new Exception("Debe seleccionar un motivo");
                    }

                    if (txtComentario.TextLength == 0)
                    {
                        throw new Exception("Debe ingresar un comentario");
                    }

                    String strRutaDoc = openFileDialog1.FileName;

                    if (strRutaDoc == "")
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

                        MessageBox.Show("Docente inhabilitado");
                        this.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha producido un error: " + ex.Message);
                }
            }
        
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EstadoDocente_Load(object sender, EventArgs e)
        {
            objDocenteBE = objDocente.GetDocente(Convert.ToInt16(Codigo));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox3.Text = folderBrowserDialog1.SelectedPath.ToString();
        }
    }
}
