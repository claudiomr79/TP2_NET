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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            
        }
        public void Listar()
        {
            this.dgvUsuarios.AutoGenerateColumns = false;
            UsuarioLogic ul = new UsuarioLogic();
            this.dgvUsuarios.DataSource = ul.GetAll();
        }

        private void Usuarios_Load(object sender, EventArgs e)
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

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            UsuarioDesktop formUsuario = new UsuarioDesktop(ApplicationForm.ModoForm.Alta);
            formUsuario.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            //int filasSeleccionadas = this.dgvUsuarios.SelectedRows.Count;
            //bool filaEsNula = filasSeleccionadas == 0 ? true : false;
            try
            {
                //if (!filaEsNula) //hay filas seleccionadas
                //{
                    int ID = ((Business.Entities.Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).ID;
                    UsuarioDesktop formUsuario = new UsuarioDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                    formUsuario.ShowDialog();
                    this.Listar();
                //}    

            }
            catch (Exception ex)
            {
                   MessageBox.Show("Seleccione una FILA!!");
            }
            
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            //int filasSeleccionadas = this.dgvUsuarios.SelectedRows.Count;
            //bool filaEsNula = filasSeleccionadas == 0 ? true : false;
            try
            {
                //if (!filaEsNula) //hay filas seleccionadas
                //{
                    int ID = ((Business.Entities.Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).ID;
                    UsuarioDesktop formUsuario = new UsuarioDesktop(ID, ApplicationForm.ModoForm.Baja);
                    formUsuario.ShowDialog();
                    this.Listar();
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione una FILA!!");
            }

        }
    }
}
