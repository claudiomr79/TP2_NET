using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class Cursos : Form
    {
        public Cursos()
        {
            InitializeComponent();
        }
        public void Listar()
        {
            this.dgvCursos.AutoGenerateColumns = false;
            CursoLogic cl = new CursoLogic();
            this.dgvCursos.DataSource = cl.GetAll();
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            try
            {
                this.Listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            CursoDesktop formCurso = new CursoDesktop(ApplicationForm.ModoForm.Alta);
            formCurso.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            try
            {

                int ID = ((Business.Entities.Curso)this.dgvCursos.SelectedRows[0].DataBoundItem).ID;
                CursoDesktop formCurso = new CursoDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                formCurso.ShowDialog();
                this.Listar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione una FILA!!");
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = ((Business.Entities.Curso)this.dgvCursos.SelectedRows[0].DataBoundItem).ID;
                CursoDesktop formCurso = new CursoDesktop(ID, ApplicationForm.ModoForm.Baja);
                formCurso.ShowDialog();
                this.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione una FILA!!");
            }
        }
    }
}
