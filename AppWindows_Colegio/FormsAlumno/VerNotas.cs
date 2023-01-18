using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWindows_Colegio.FormsAlumno
{
    public partial class VerNotas : Form
    {

        ProxyAlumno.ServicioAlumnoClient objAlumno = new ProxyAlumno.ServicioAlumnoClient();
        ProxyAlumno.AlumnoBE objAlumnoBE = new ProxyAlumno.AlumnoBE();
        ProxyCurso.ServicioCursoClient objCurso = new ProxyCurso.ServicioCursoClient();

        public VerNotas()
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
            cboCurso.DataSource = objCurso.GetCursos();
            cboCurso.ValueMember = "IdCurso";
            cboCurso.DisplayMember = "Descripcion";

            cboCurso.SelectedItem = null;
        }

        private void CargarPeriodos()
        {
            cboPeriodo.DataSource = objAlumno.GetPeriodos();
            cboPeriodo.ValueMember = "Mvarid_periodo";
            cboPeriodo.DisplayMember = "Mvardes_periodo";

            cboPeriodo.SelectedItem = null;
        }

        private void VerNotas_Load(object sender, EventArgs e)
        {
            try
            {
                objAlumnoBE = objAlumno.GetAlumno(Convert.ToInt16(Codigo));

                lblCodigo.Text = objAlumnoBE.Mvarcod_al;
                lblName.Text = objAlumnoBE.Mvarape_al + ", " + objAlumnoBE.Mvarnom_al;
                cboCurso.SelectedValue = Convert.ToString(objAlumnoBE.Mvaridcurso);
                CargarCursos();
                CargarPeriodos();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvNotas.AutoGenerateColumns = false;

                

                if (cboCurso.SelectedItem == null)
                {
                    throw new Exception("Debe seleccionar un curso");
                }

                if (cboPeriodo.SelectedItem == null)
                {
                    throw new Exception("Seleccione periodo escolar");
                }

                ProxyAlumno.AlumnoBE alumnoBE = objAlumno.GetAlumno(Convert.ToInt16(Codigo));

                dgvNotas.DataSource = objAlumno.GetNotas(Convert.ToInt16(cboCurso.SelectedValue), Convert.ToInt16(Codigo), Convert.ToInt16(cboPeriodo.SelectedValue));

                if (dgvNotas.RowCount == 0)
                {
                    
                    throw new Exception("No hay notas almacenadas");

                }


                for (int i = 0; i < dgvNotas.Rows.Count ; i++)
                { 
                    for(int j =0; j<dgvNotas.Rows[i].Cells.Count; j++)
                    {

                        double nota1 = Convert.ToDouble(dgvNotas.Rows[i].Cells["NotaU1"].Value);
                        double nota2 = Convert.ToDouble(dgvNotas.Rows[i].Cells["NotaU2"].Value);
                        double nota3 = Convert.ToDouble(dgvNotas.Rows[i].Cells["NotaU3"].Value);
                        double notafinal = Convert.ToDouble(dgvNotas.Rows[i].Cells["UFinal"].Value);

                        double prom1 = (nota1 + nota2 + nota3) / 3;
                        double prom2 = prom1 * 0.7;
                        double prom3 = notafinal * 0.3;
                        double promprefinal = prom2 + prom3;
                        double promfinal = Math.Truncate(promprefinal * 100) / 100;

                        dgvNotas.Rows[i].Cells["Promedio"].Value = promfinal;

                        if(promfinal<12.5)
                        {
                            dgvNotas.Rows[i].Cells["Promedio"].Style.BackColor = Color.Red;
                            
                        }
                        else
                        {
                            dgvNotas.Rows[i].Cells["Promedio"].Style.BackColor = Color.Green;
                        }

                        if (nota1 < 13)
                        {
                            dgvNotas.Rows[i].Cells["NotaU1"].Style.ForeColor = Color.Red;

                        }

                        if (nota2 < 13)
                        {
                            dgvNotas.Rows[i].Cells["NotaU2"].Style.ForeColor = Color.Red;

                        }

                        if (nota3 < 13)
                        {
                            dgvNotas.Rows[i].Cells["NotaU3"].Style.ForeColor = Color.Red;

                        }

                        if (notafinal < 13)
                        {
                            dgvNotas.Rows[i].Cells["UFinal"].Style.ForeColor = Color.Red;

                        }
                    }
                   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }
           
 
        }

        private void btnPromediar_Click(object sender, EventArgs e)
        {

           
        }
    }
}
