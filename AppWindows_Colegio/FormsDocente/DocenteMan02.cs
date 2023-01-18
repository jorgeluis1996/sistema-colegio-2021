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
    public partial class DocenteMan02 : Form
    {
        ProxyDocente.ServicioDocenteClient objDocente = new ProxyDocente.ServicioDocenteClient();
        ProxyDocente.DocenteBE objDocenteBE = new ProxyDocente.DocenteBE();
        ProxyExtra.IServicioExtraClient objExtra = new ProxyExtra.IServicioExtraClient();

        public DocenteMan02()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estas seguro que quieres grabar estos datos?", "Confirmacion", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
                try
            {
                if (txtNombre.Text.Length == 0)
                {
                    throw new Exception("El nombre no puede estar vacio");
                }

                if (txtApellido.Text.Length == 0)
                {
                    throw new Exception("El apellido no puede estar vacio");
                }

                if (txtGrado.Text.Length == 0)
                {
                    throw new Exception("El grado de estudio no puede estar vacio");
                }

                if (mskDNI.MaskFull == false)
                {
                    throw new Exception("El DNI debe tener 8 caracteres");
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
                objDocenteBE.Mvarid_distritro = Convert.ToInt32(cboDistrito.SelectedValue);
                objDocenteBE.Direccion1 = txtDireccion.Text.Trim();
                objDocenteBE.Grado_estudio = txtGrado.Text.Trim();
                objDocenteBE.Numero_tel1 = mskTelefono.Text;
                objDocenteBE.Email = txtEmail.Text.Trim();

                if (objDocente.InsertDocente(objDocenteBE) == true)
                {
                    MessageBox.Show("Docente registrado correctamente");
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estas seguro que quieres cancelar?", "Confirmacion", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)

                this.Close();
        }

        private void DocenteMan02_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDistrito(1);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);

            }
        }
        private void CargarDistrito(Int32 IdDist)
        {
            cboDistrito.DataSource = objExtra.ListarDistritos();
            cboDistrito.ValueMember = "MvarId_distrito";
            cboDistrito.DisplayMember = "MvarNombre_distritro";
            cboDistrito.SelectedValue = IdDist;
        }

    }
}
