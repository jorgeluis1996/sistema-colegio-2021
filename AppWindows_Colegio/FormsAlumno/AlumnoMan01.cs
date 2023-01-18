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
    public partial class AlumnoMan01Gnral : Form
    {
        ProxyAlumno.ServicioAlumnoClient objAlumnoGnral = new ProxyAlumno.ServicioAlumnoClient();
        ProxyExtra.IServicioExtraClient objExtraGnral = new ProxyExtra.IServicioExtraClient();
  

        public AlumnoMan01Gnral()
        {
            InitializeComponent();
        }

        public void CargarDatosGnral(String strFiltro)
        {

            if (strFiltro.Equals(""))
            {
                ProxyAlumno.AlumnoBE[] alumnoBEs = objAlumnoGnral.GetAllAlumnos();
                btnTopAlumnoGnral.DataSource = alumnoBEs;

                for (int i = 0; i < alumnoBEs.Length; i++)
                {
                    if (alumnoBEs[i].Mvaract_al == false)
                    {
                        btnTopAlumnoGnral.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                       
                        
                    }
                }

                lblRegistrosGneral.Text = btnTopAlumnoGnral.Rows.Count.ToString();
            }
            else 
            {
                btnTopAlumnoGnral.DataSource = objAlumnoGnral.BuscarAlumnos(strFiltro);
            }


        }

        private void AlumnoMan01_Load(object sender, EventArgs e)
        {
            try
            {
                btnTopAlumnoGnral.AutoGenerateColumns = false;

                
                CargarDatosGnral("");
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnInsertarGnral_Click(object sender, EventArgs e)
        {
            try
            {
                AlumnoMan02 oAlumnoMan02 = new AlumnoMan02();
                oAlumnoMan02.ShowDialog();

                CargarDatosGnral("");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }
            
        }

        private void btnActualizarGnral_Click(object sender, EventArgs e)
        {
            if (btnTopAlumnoGnral.CurrentCell != null)
            {
                try
                {
                    AlumnoMan03 OAlumnoMan03 = new AlumnoMan03();
                    OAlumnoMan03.Codigo = btnTopAlumnoGnral.CurrentRow.Cells[0].Value.ToString();

                    OAlumnoMan03.ShowDialog();
                    CargarDatosGnral("");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else { MessageBox.Show("Seleccione un alumno"); }

        }



        private void btnEliminarGnral_Click(object sender, EventArgs e)
        
        {
            DialogResult r = MessageBox.Show("¿Estas seguro que quieres ejecutar esta accion?", "Confirmacion", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)

                if (btnTopAlumnoGnral.CurrentCell != null)
                {
                    try
                    {

                        Int16 idAlumno = Convert.ToInt16(btnTopAlumnoGnral.CurrentRow.Cells[0].Value.ToString());
                        ProxyAlumno.AlumnoBE alumnoBE = objAlumnoGnral.GetAlumno(idAlumno);


                        if (alumnoBE.Mvaract_al == true)
                        {

                            EstadoAlumno OEstadoAlumno = new EstadoAlumno();
                            OEstadoAlumno.Codigo = btnTopAlumnoGnral.CurrentRow.Cells[0].Value.ToString();
                        
                            OEstadoAlumno.ShowDialog();

                        }
                        else
                        {
                            EstadoAlumno02 OEstadoAlumno02 = new EstadoAlumno02();
                            OEstadoAlumno02.Codigo = btnTopAlumnoGnral.CurrentRow.Cells[0].Value.ToString();
                        
                            OEstadoAlumno02.ShowDialog();

                        }


                        CargarDatosGnral("");
                    }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Error : " + ex.Message);
                        }

                }

                else { MessageBox.Show("Seleccione un alumno"); }

        }

        private void BtnPromediar_Click(object sender, EventArgs e)
        {
            TopAlumnoForm topAlumnoForm = new TopAlumnoForm();
            topAlumnoForm.ShowDialog();
        }

        

        private void btnInsertNotas_Click(object sender, EventArgs e)
        {
            try
            {
                // NO CODIFICAR
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estas seguro que quieres Volver?", "Confirmacion", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)        

            this.Close();
        }

        private void txtFiltroGnral_TextChanged(object sender, EventArgs e)
        {
            CargarDatosGnral(txtFiltroGnral.Text.Trim());
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {          
            //NO CODIFICAR           
        }

        private void btnRegistrarNotas_Click(object sender, EventArgs e)
        {
            Int16 idAlumno = Convert.ToInt16(btnTopAlumnoGnral.CurrentRow.Cells[0].Value.ToString());
            ProxyAlumno.AlumnoBE alumnoBE = objAlumnoGnral.GetAlumno(idAlumno);

            if (btnTopAlumnoGnral.CurrentCell != null)
            {
                RegistarNotas registarNotas = new RegistarNotas();
                registarNotas.Codigo = btnTopAlumnoGnral.CurrentRow.Cells[0].Value.ToString();

                registarNotas.ShowDialog();
                CargarDatosGnral("");
            }

            else { MessageBox.Show("Seleccione un alumno"); }
        }

        /*private void btnMostrarOcultar_Click(object sender, EventArgs e)
        {
            ProxyAlumno.AlumnoBE[] alumnoBEs = objAlumnoGnral.GetAllAlumnos();

            for (int i = 0; i < alumnoBEs.Length; i++)
            {
                if (alumnoBEs[i].Mvaract_al == false && btnTopAlumnoGnral.Rows[i].Visible == false)
                {
                    this.btnTopAlumnoGnral.CurrentCell = this.btnTopAlumnoGnral[1, 0];
                    btnTopAlumnoGnral.Rows[i].Visible = true;

                }

                else
                {
                    if (alumnoBEs[i].Mvaract_al == false && btnTopAlumnoGnral.Rows[i].Visible == true)
                    {
                        this.btnTopAlumnoGnral.CurrentCell = this.btnTopAlumnoGnral[1, 0];
                        btnTopAlumnoGnral.Rows[i].Visible = false;
                    }

                }
            }
        }*/
        
        private void btnVerNotas_Click(object sender, EventArgs e)
        {
            if (btnTopAlumnoGnral.CurrentCell != null)
            {
                try
                {
                    VerNotas verNotas = new VerNotas();
                    verNotas.Codigo = btnTopAlumnoGnral.CurrentRow.Cells[0].Value.ToString();
                    verNotas.ShowDialog();
                    CargarDatosGnral("");
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
