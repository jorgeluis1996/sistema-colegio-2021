using AppWindows_Colegio.FormsAlumno;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWindows_Colegio
{
    public partial class AlumnoMan01 : Form
    {
        ProxyAlumno.ServicioAlumnoClient objAlumno = new ProxyAlumno.ServicioAlumnoClient();
        ProxyExtra.IServicioExtraClient objExtra = new ProxyExtra.IServicioExtraClient();
  

        public AlumnoMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos(String strFiltro)
        {

            if (strFiltro.Equals(""))
            {
                ProxyAlumno.AlumnoBE[] alumnoBEs = objAlumno.GetAllAlumnos();
                grvAlumnos.DataSource = alumnoBEs;

                for (int i = 0; i < alumnoBEs.Length; i++)
                {
                    if (alumnoBEs[i].Mvaract_al == false)
                    {
                        grvAlumnos.CurrentCell = null;
                        grvAlumnos.Rows[i].Visible = false;

                        int contar = grvAlumnos.Rows.Cast<DataGridViewRow>()
                              .Where(r => r.Cells["Estado"].Value.ToString().Contains("True"))
                              .Count();

                        lblRegistros.Text = Convert.ToString(contar);
                    }
                }
            }
            else 
            {
                grvAlumnos.DataSource = objAlumno.BuscarAlumnos(strFiltro);
            }
    
            
           
        }

        private void AlumnoMan01Docente_Load(object sender, EventArgs e)
        {
            try
            {
                grvAlumnos.AutoGenerateColumns = false;
              
                CargarDatos("");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estas seguro que desea cerrar sesión?", "Confirmacion", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {     
                this.Hide();
                frmLogin f1 = new frmLogin();
                f1.Show();
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarDatos(txtFiltro.Text.Trim());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegistrarNota_Click(object sender, EventArgs e)
        {
            if (grvAlumnos.CurrentCell != null)
            {
                RegistarNotas registarNotas = new RegistarNotas();
                registarNotas.Codigo = grvAlumnos.CurrentRow.Cells[0].Value.ToString();
                registarNotas.ShowDialog();
                CargarDatos("");
            }
            else { MessageBox.Show("Seleccione un alumno"); }
        }

        private void btnVerNotas_Click(object sender, EventArgs e)
        {
            if (grvAlumnos.CurrentCell != null)
            {
                try
                {
                    VerNotas verNotas = new VerNotas();
                    verNotas.Codigo = grvAlumnos.CurrentRow.Cells[0].Value.ToString();
                    verNotas.ShowDialog();
                    CargarDatos("");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error: " + ex.Message); ;
                }
            }

            else { MessageBox.Show("Seleccione un alumno"); }

        }
    }
}
