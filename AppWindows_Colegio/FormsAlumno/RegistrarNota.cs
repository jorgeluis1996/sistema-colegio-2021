using AppWindows_Colegio.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppWindows_Colegio
{
    public partial class RegistarNotas : Form
    {
        ProxyAlumno.ServicioAlumnoClient objAlumno = new ProxyAlumno.ServicioAlumnoClient();
        ProxyAlumno.AlumnoBE objAlumnoBE = new ProxyAlumno.AlumnoBE();
        ProxyExtra.IServicioExtraClient objExtra = new ProxyExtra.IServicioExtraClient();
        ProxyCurso.ServicioCursoClient objCurso = new ProxyCurso.ServicioCursoClient();
        
        public RegistarNotas()
        {
            InitializeComponent();
        }

        private String _Codigo;
        public String Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }

        }


        private void RegistarNotas_Load(object sender, EventArgs e)
        {
            try
            {          
                objAlumnoBE = objAlumno.GetAlumno(Convert.ToInt16(Codigo));
                lblCodigo.Text = objAlumnoBE.Mvarcod_al;
                lblName.Text = objAlumnoBE.Mvarape_al + ", " + objAlumnoBE.Mvarnom_al;
                cboCurso.SelectedValue = Convert.ToString(objAlumnoBE.Mvaridcurso);

                cboPeriodo.SelectedItem = null;
                CargarCursos();
                CargarPeriodos();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void AlumnoMan03_Load(object sender, EventArgs e)
        {
            // NO CODIFICAR
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                //NO CODIFICAR
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

        }

        private void CargarCursos()
        {
            cboCurso.DataSource = objCurso.GetCursos();
            cboCurso.ValueMember = "IdCurso";
            cboCurso.DisplayMember = "Descripcion";
        }

        private void CargarPeriodos()
        {
            cboPeriodo.DataSource = objAlumno.GetPeriodos();
            cboPeriodo.ValueMember = "Mvarid_periodo";
            cboPeriodo.DisplayMember = "Mvardes_periodo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void grpDatos_Enter(object sender, EventArgs e)
        {

        }

        private void btnPromediar_Click(object sender, EventArgs e)
        {
           

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estas seguro que quieres grabar estos datos?", "Confirmacion", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {     
                try
                {

                    if (cboPeriodo.SelectedItem == null)
                    {
                        throw new Exception("Seleccione periodo escolar");
                    }
                    if (cbxNota1.SelectedItem == null )
                    {
                        throw new Exception("Ingrese Nota 1");
                    }
                    if (cbxnota2.SelectedItem == null)
                    {
                        throw new Exception("Ingrese Nota 2");
                    }
                    if (cbxnota3.SelectedItem == null)
                    {
                        throw new Exception("Ingrese Nota 4");
                    }
                    if (cbxfinal.SelectedItem == null)
                    {
                        throw new Exception("Ingrese Nota final");
                    }
                    if (txtRetro.Text.Length == 0)
                    {
                        throw new Exception("Debe ingresar retroalimentacion");
                    }

                    if (cboCurso.SelectedItem == null)
                    {
                        throw new Exception("Debe seleccionar un curso");
                    }

                    objAlumnoBE.Mvarnota1 = Convert.ToInt32(cbxNota1.SelectedItem);
                    objAlumnoBE.Mvarnota2 = Convert.ToInt32(cbxnota2.SelectedItem);
                    objAlumnoBE.Mvarnota3 = Convert.ToInt32(cbxnota3.SelectedItem);
                    objAlumnoBE.Mvarfinal = Convert.ToInt32(cbxfinal.SelectedItem);
                    objAlumnoBE.Mvarretro = txtRetro.Text;
                    objAlumnoBE.Mvarid_curso = Convert.ToInt16(cboCurso.SelectedValue);
                    objAlumnoBE.Mvarid_periodo = Convert.ToInt32(cboPeriodo.SelectedValue);
                   

                    if (objAlumno.RegistrarNotas(objAlumnoBE) == true)
                    {
                        MessageBox.Show("Notas registradas exitosamente");
                        this.Close();
                    }
                    
                    else
                    {
                        throw new Exception("Registro no se insertó. Contacte con IT");
                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show("Se ha producido un error: " + ex.Message);
                }

            }
        }

    }
}

