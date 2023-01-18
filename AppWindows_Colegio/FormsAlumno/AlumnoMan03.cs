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

namespace AppWindows_Colegio
{
    public partial class AlumnoMan03 : Form
    {
        ProxyAlumno.ServicioAlumnoClient objAlumno = new ProxyAlumno.ServicioAlumnoClient();
        ProxyAlumno.AlumnoBE objAlumnoBE = new ProxyAlumno.AlumnoBE();
        ProxyExtra.IServicioExtraClient objExtra = new ProxyExtra.IServicioExtraClient();

        public AlumnoMan03()
        {
            InitializeComponent();
        }

        private String _Codigo;

        public String Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }

        }

        private void AlumnoMan03_Load(object sender, EventArgs e)
        {
            try
            {
                objAlumnoBE = objAlumno.GetAlumno(Convert.ToInt16(Codigo));

                lblCodigo.Text = objAlumnoBE.Mvarcod_al;
                txtNombre.Text = objAlumnoBE.Mvarnom_al;
                txtApellido.Text = objAlumnoBE.Mvarape_al;
                mskDNI.Text = objAlumnoBE.Mvardocide_al;
                dtpFecNac.Value = Convert.ToDateTime(objAlumnoBE.Mvarfecnac_al);
                cbxSexo.SelectedItem = objAlumnoBE.Mvarsex_al;
                cboDistrito.SelectedValue = Convert.ToString(objAlumnoBE.Mvarid_distrito);
                txtDireccion.Text = objAlumnoBE.Mvardir_al;

                CargarDistrito();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);    
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estas seguro que quieres actualizar esta información ?", "Confirmacion", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)

                try
            {

                if (txtNombre.Text.Length == 0)
                {
                    MessageBox.Show("El Nombre no puede estar vacio.");
                }

                if (txtApellido.Text.Length == 0)
                {
                    MessageBox.Show("El Apellido no puede estar vacio.");
                }

                if (mskDNI.MaskFull == false)
                {
                    throw new Exception("El DNI debe tener 8 caracteres.");

                }
                if (cbxSexo.SelectedItem == null)
                {
                    throw new Exception("El sexo debe ser obligatorio");
                }


                objAlumnoBE.Mvarnom_al = txtNombre.Text.Trim();
                objAlumnoBE.Mvarape_al = txtApellido.Text.Trim();
                objAlumnoBE.Mvardocide_al = mskDNI.Text;
                objAlumnoBE.Mvarfecnac_al = dtpFecNac.Value.Date;
                if (cbxSexo.SelectedItem.ToString() == "Femenino")
                {
                    objAlumnoBE.Mvarsex_al = "Femenino";
                }
                else
                {
                    objAlumnoBE.Mvarsex_al = "Masculino";
                }
                objAlumnoBE.Mvarid_distrito = Convert.ToInt16(cboDistrito.SelectedValue);
                objAlumnoBE.Mvardir_al = txtDireccion.Text.Trim();
                objAlumnoBE.Mvaract_al = true;
                objAlumnoBE.Usu_ult_mod = clsCredenciales.Usuario;
               

                if (objAlumno.UpdateAlumno(objAlumnoBE) == true)
                {
                    MessageBox.Show("Actualizacion exitosa");
                    this.Close();
                }
                else
                {
                    throw new Exception("Registro no se actualizo. Contacte con IT");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

        }

        private void CargarDistrito()
        {
            cboDistrito.DataSource = objExtra.ListarDistritos();
            cboDistrito.ValueMember = "MvarId_distrito";
            cboDistrito.DisplayMember = "MvarNombre_distritro";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estas seguro que quieres salir?", "Confirmacion", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)

                this.Close();
        }

        private void grpDatos_Enter(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpFecNac_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
