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
    public partial class CursoMan03 : Form
    {
        ProxyCurso.ServicioCursoClient objCurso = new ProxyCurso.ServicioCursoClient();
        ProxyCurso.CursoBE objCursoBE = new ProxyCurso.CursoBE();
        public CursoMan03()
        {
            InitializeComponent();
        }

        private String _Codigo;

        public String Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }

        }

        private void CursoMan03_Load(object sender, EventArgs e)
        {
            try
            {
               
                objCursoBE = objCurso.GetCurso(Convert.ToInt16(Codigo));
       
                txtDescripcion.Text = objCursoBE.Descripcion;
  

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescripcion.Text.Length == 0)
                {
                    throw new Exception("El nombre no puede estar vacio");
                }

                objCursoBE.Descripcion = txtDescripcion.Text.Trim();

                if (objCurso.UpdateCurso(objCursoBE) == true)
                {
                    MessageBox.Show("Curso Actualizado");
                    this.Close();
                }
                else
                {
                    throw new Exception("Registro no se actualizo. Contacto con IT");
                }
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
