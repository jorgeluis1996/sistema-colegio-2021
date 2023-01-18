using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWindows_Colegio.FormsCurso
{
    public partial class AsignarCurso : Form
    {
        ProxyDocente.ServicioDocenteClient objDocente = new ProxyDocente.ServicioDocenteClient();
        ProxyCurso.CursoBE objCursoBE = new ProxyCurso.CursoBE();
        ProxyCurso.ServicioCursoClient objCurso = new ProxyCurso.ServicioCursoClient();
        ProxyDocente.DocenteBE objDocenteBE = new ProxyDocente.DocenteBE();
        ProxyExtra.IServicioExtraClient objExtra = new ProxyExtra.IServicioExtraClient();

        public AsignarCurso()
        {
            InitializeComponent();
        }

        private String _Codigo;

        public String Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }

        }

        private void CargarCursos()
        {
            cboDocente.DataSource = objDocente.GetAllDocentes();
            cboDocente.ValueMember = "Id_Docente1";
            cboDocente.DisplayMember = "NombresApellidos";

            cboDocente.SelectedItem = null;
        }

        private void AsignarCurso_Load(object sender, EventArgs e)
        {
            try
            {
                objCursoBE = objCurso.GetCurso(Convert.ToInt16(Codigo));

                lblCursoSelect.Text = objCursoBE.Descripcion;
           
                CargarCursos();
             
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                objExtra.AsignarCursoDocente(Convert.ToInt32(Codigo), Convert.ToInt32(cboDocente.SelectedValue));
                MessageBox.Show("Docente asignado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
