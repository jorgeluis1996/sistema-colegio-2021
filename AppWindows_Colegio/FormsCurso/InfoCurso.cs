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
using System.Data.Sql;

namespace AppWindows_Colegio.FormsCurso
{
    public partial class InfoCurso : Form
    {
        ProxyDocente.ServicioDocenteClient objDocente = new ProxyDocente.ServicioDocenteClient();
        ProxyCurso.CursoBE objCursoBE = new ProxyCurso.CursoBE();
        ProxyCurso.ServicioCursoClient objCurso = new ProxyCurso.ServicioCursoClient();
        ProxyDocente.DocenteBE objDocenteBE = new ProxyDocente.DocenteBE();
        ProxyExtra.IServicioExtraClient objExtra = new ProxyExtra.IServicioExtraClient();

        public InfoCurso()
        {
            InitializeComponent();
        }

        private String _Codigo;

        public String Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }

        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void InfoCurso_Load(object sender, EventArgs e)
        {
            try
            {
                objCursoBE = objCurso.DetalleCursoNivel(Convert.ToInt16(Codigo));

                //ESTO SE PUEDE MEJORAR

                lblCodigo.Text = objCursoBE.Codigo;
                lblCursoSelect.Text = objCursoBE.Descripcion;

                if(objCursoBE.IdNivel == 1)
                {
                    lblNivel.Text = "PRIMARIA Y SECUNDARIA";
                }
                if(objCursoBE.IdNivel == 2)
                {
                    lblNivel.Text = "PRIMARIA";
                }
                if (objCursoBE.IdNivel == 3)
                {
                    lblNivel.Text = "SECUNDARIA";
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
