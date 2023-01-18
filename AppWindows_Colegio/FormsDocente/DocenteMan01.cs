
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppWindows_Colegio.FormsDocente;

namespace AppWindows_Colegio
{
    public partial class DocenteMan01 : Form
    {
        ProxyDocente.ServicioDocenteClient objDocente = new ProxyDocente.ServicioDocenteClient();

        public DocenteMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos(String strFiltro)
        {
            if (strFiltro.Equals(""))
            {
                ProxyDocente.DocenteBE[] docenteBEs = objDocente.GetAllDocentes();
                dtgDocente.DataSource = docenteBEs;


                for (int i = 0; i < docenteBEs.Length; i++)
                {
                    if (docenteBEs[i].Mvaract_doc == false)
                    {
                        dtgDocente.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                    }
                }

                lblRegistrosDocentes.Text = dtgDocente.Rows.Count.ToString();
            }
            else
            {
                dtgDocente.DataSource = objDocente.BuscarDocentes(strFiltro);
            }


        }


        private void DocenteMan01_Load(object sender, EventArgs e)
        {
            try
            {
                dtgDocente.AutoGenerateColumns = false;
               
                CargarDatos("");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                DocenteMan02 oDocenteMan02 = new DocenteMan02();
                oDocenteMan02.ShowDialog();

                CargarDatos("");
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

                DocenteMan03 ODocenteMan03 = new DocenteMan03();
                ODocenteMan03.Codigo = dtgDocente.CurrentRow.Cells[0].Value.ToString();
                ODocenteMan03.ShowDialog();
                CargarDatos("");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {


            DialogResult r = MessageBox.Show("¿Estas seguro que quieres realizar este cambio ?", "Confirmacion", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                try
                {

                    Int16 idDocente = Convert.ToInt16(dtgDocente.CurrentRow.Cells[0].Value.ToString());
                    ProxyDocente.DocenteBE docenteBE = objDocente.GetDocente(idDocente);

                    if (docenteBE.Mvaract_doc == true)
                    {
                        EstadoDocente OEstadoDocente = new EstadoDocente();
                        OEstadoDocente.Codigo = dtgDocente.CurrentRow.Cells[0].Value.ToString();
                        OEstadoDocente.ShowDialog();

                    }

                    else
                    {
                        EstadoDocente02 OEstadoDocente02 = new EstadoDocente02();
                        OEstadoDocente02.Codigo = dtgDocente.CurrentRow.Cells[0].Value.ToString();
                        OEstadoDocente02.ShowDialog();

                    }

                    CargarDatos("");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error : " + ex.Message);
                }
            }



        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estas seguro que quieres salir?", "Confirmacion", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
                this.Close();
        }

        private void txtFiltro2_TextChanged(object sender, EventArgs e)
        {
            CargarDatos(txtFiltro2.Text.Trim());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarOcultar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarOcultar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
