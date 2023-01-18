using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppWindows_Colegio.FormsCurso;

namespace AppWindows_Colegio
{
    public partial class CursoMan01 : Form
    {
        ProxyCurso.ServicioCursoClient objCurso = new ProxyCurso.ServicioCursoClient();

        public CursoMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            //Codifique
            //dtgCursos.DataSource = objCurso.GetCursos();
           // lblRegistros.Text = dtgCursos.Rows.Count.ToString();

            ProxyCurso.CursoBE[] cursoBEs = objCurso.GetCursos();
            dtgCursos.DataSource = cursoBEs;

            for (int i = 0; i < cursoBEs.Length; i++)
            {
                if (cursoBEs[i].Activocur == false)
                {
                    dtgCursos.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;


                }
            }

            lblRegistros.Text = dtgCursos.Rows.Count.ToString();
        }

        private void CursoMan01_Load(object sender, EventArgs e)
        {
            try
            {
                dtgCursos.AutoGenerateColumns = false;
                CargarDatos();
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
                CursoMan03 oCursoMan03 = new CursoMan03();
                oCursoMan03.Codigo = dtgCursos.CurrentRow.Cells[0].Value.ToString();
                oCursoMan03.ShowDialog();

                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                CursoMan02 oCursoMan02 = new CursoMan02();
                oCursoMan02.ShowDialog();

                CargarDatos();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Estas seguro que quieres ejecutar esta accion?", "Confirmacion", MessageBoxButtons.YesNo);

                if (r == DialogResult.Yes)

                    if (dtgCursos.CurrentCell != null)
                    {
                        try
                        {

                            Int16 idCurso = Convert.ToInt16(dtgCursos.CurrentRow.Cells[0].Value.ToString());
                            ProxyCurso.CursoBE cursoBE = objCurso.GetCurso(idCurso);


                            if (cursoBE.Activocur == true)
                            {

                                EstadoCurso OEstadoCurso = new EstadoCurso();
                                OEstadoCurso.Codigo = dtgCursos.CurrentRow.Cells[0].Value.ToString();

                                OEstadoCurso.ShowDialog();

                            }
                            else
                            {
                                EstadoCurso02 OEstadoCurso02 = new EstadoCurso02();
                                OEstadoCurso02.Codigo = dtgCursos.CurrentRow.Cells[0].Value.ToString();

                                OEstadoCurso02.ShowDialog();

                            }

                            CargarDatos();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Error : " + ex.Message);
                        }

                    }

                    else { MessageBox.Show("Seleccione un alumno"); }
            }

            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAsignarCurso_Click(object sender, EventArgs e)
        {
            Int16 idCurso = Convert.ToInt16(dtgCursos.CurrentRow.Cells[0].Value.ToString());
            ProxyCurso.CursoBE cursoBE = objCurso.GetCurso(idCurso);

            try
            {
                if (dtgCursos.CurrentCell != null)
                {
                    AsignarCurso oAsignarCurso = new AsignarCurso();
                    oAsignarCurso.Codigo = dtgCursos.CurrentRow.Cells[0].Value.ToString();
                    oAsignarCurso.ShowDialog();
                    CargarDatos();
                }

                else { MessageBox.Show("Seleccione un curso"); }

                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }

           
            
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            if (dtgCursos.CurrentCell != null)
            {
                try
                {
                    InfoCurso verInfo = new InfoCurso();
                    verInfo.Codigo = dtgCursos.CurrentRow.Cells[0].Value.ToString();
                    verInfo.ShowDialog();
                    CargarDatos();
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
