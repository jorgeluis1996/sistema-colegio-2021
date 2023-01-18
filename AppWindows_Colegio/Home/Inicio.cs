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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlumnoMan01Gnral oalumnoMan01 = new AlumnoMan01Gnral();
            oalumnoMan01.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DocenteMan01 docenteMan01 = new DocenteMan01();
            docenteMan01.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estas seguro que desea cerrar sesión?", "Confirmacion", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                this.Hide();
                frmLogin f1 = new frmLogin();
                f1.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CursoMan01 ocursoMan01 = new CursoMan01();
            ocursoMan01.ShowDialog();
        }
    }
}
