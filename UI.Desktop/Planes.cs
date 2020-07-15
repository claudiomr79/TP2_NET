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
    public partial class Planes : Form
    {
        public Planes()
        {
            InitializeComponent();
        }
        public void Listar()
        {
            this.dgvPlanes.AutoGenerateColumns = false;
            PlanLogic pl = new PlanLogic();
            this.dgvPlanes.DataSource = pl.GetAll();
        }
        private void Planes_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            try
            {
                
                int ID = ((Business.Entities.Plan)this.dgvPlanes.SelectedRows[0].DataBoundItem).ID;
                PlanDesktop formPlan = new PlanDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                formPlan.ShowDialog();
                this.Listar();
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione una FILA!!");
            }
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            PlanDesktop formPlan = new PlanDesktop(ApplicationForm.ModoForm.Alta);
            formPlan.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                
                int ID = ((Business.Entities.Plan)this.dgvPlanes.SelectedRows[0].DataBoundItem).ID;
                PlanDesktop formPlan = new PlanDesktop(ID, ApplicationForm.ModoForm.Baja);
                formPlan.ShowDialog();
                this.Listar();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione una FILA!!");
            }
        }
    }
}
