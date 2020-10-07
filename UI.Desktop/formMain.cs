using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void formMain_Load(object sender, EventArgs e)
        {

        }

        private void formMain_Shown(object sender, EventArgs e)
        {
            formLogin appLogin = new formLogin();
            if (appLogin.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }
    

        }

        private void ABMUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Usuarios AbmUsuarios = new Usuarios();
            AbmUsuarios.ShowDialog();
        }

        private void aBMPlanesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Planes AbmPlanes = new Planes();
            AbmPlanes.ShowDialog();
        }

        private void aBMMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materias AbmMaterias = new Materias();
            AbmMaterias.ShowDialog();
        }

        private void aBMEspecialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Especialidades AbmEspecialidades = new Especialidades();
            AbmEspecialidades.ShowDialog();
        }
    }
}
