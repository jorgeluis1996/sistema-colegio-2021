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
    public partial class DocenteMan03 : Form
    {
        ProxyDocente.ServicioDocenteClient objDocente = new ProxyDocente.ServicioDocenteClient();
        ProxyDocente.DocenteBE objDocenteBE = new ProxyDocente.DocenteBE();
        ProxyExtra.IServicioExtraClient objExtra = new ProxyExtra.IServicioExtraClient();

        public DocenteMan03()
        {
            InitializeComponent();
        }

        private String _Codigo;

        public String Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }

        }

        private void DocenteMan03_Load(object sender, EventArgs e)
        {
            try
            {
                objDocenteBE = objDocente.GetDocente(Convert.ToInt16(Codigo));

                lblCodigo.Text = objDocenteBE.Codigo;
                txtNombre.Text = objDocenteBE.Nombres;
                txtApellido.Text = objDocenteBE.Apellidos;
                mskDNI.Text = objDocenteBE.DNI1;
                dtpFecNac.Value = Convert.ToDateTime(objDocenteBE.FechaNac);
                cbxSexo.SelectedItem = objDocenteBE.Sexo;
                txtDireccion.Text = objDocenteBE.Direccion1;
                txtGrado.Text = objDocenteBE.Grado_estudio;
                txtNroTel.Text = objDocenteBE.Numero_tel1;
                txtEmail.Text = objDocenteBE.Email;

                CargarDistrito(1);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void CargarDistrito(Int32 IdDist)
        {
            cboDistrito.DataSource = objExtra.ListarDistritos();
            cboDistrito.ValueMember = "MvarId_distrito";
            cboDistrito.DisplayMember = "MvarNombre_distritro";
            cboDistrito.SelectedValue = IdDist;
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


                objDocenteBE.Nombres = txtNombre.Text.Trim();
                objDocenteBE.Apellidos = txtApellido.Text.Trim();
                objDocenteBE.DNI1 = mskDNI.Text;
                objDocenteBE.FechaNac = dtpFecNac.Value.Date;
                if (cbxSexo.SelectedItem.ToString() == "Femenino")
                {
                    objDocenteBE.Sexo = "Femenino";
                }
                else
                {
                    objDocenteBE.Sexo = "Masculino";
                }
                objDocenteBE.Direccion1 = txtDireccion.Text.Trim();
                objDocenteBE.Grado_estudio = txtGrado.Text.Trim();
                objDocenteBE.Numero_tel1 = txtNroTel.Text.Trim();
                objDocenteBE.Usu_ult_mod = clsCredenciales.Usuario;
                objDocenteBE.Mvarid_distritro = Convert.ToInt32(cboDistrito.SelectedValue);
                objDocenteBE.Email = txtEmail.Text.Trim();



                if (objDocente.UpdateDocente(objDocenteBE) == true)
                {
                    MessageBox.Show("Actualizacion exitosa");
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
            DialogResult r = MessageBox.Show("¿Estas seguro que quieres salir?", "Confirmacion", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}
