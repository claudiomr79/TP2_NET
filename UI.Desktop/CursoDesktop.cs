using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class CursoDesktop : ApplicationForm
    {
        public Business.Entities.Curso CursoActual { get; set; }
        private List<Comision> Comisiones { get; set; }
        private List<Materia> Materias { get; set; }

        public CursoDesktop(ModoForm modo) : this()
        {
            this.Modo = modo; //para altas
        }
        public CursoDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            CursoLogic curso = new CursoLogic();
            CursoActual = curso.GetOne(ID);
            MapearDeDatos();
        }
        public CursoDesktop()
        {
            InitializeComponent();

            //traigo las comisiones para el combobox IDComision
            try
            {
                Comisiones = new ComisionLogic().GetAll();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Curso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.cboIdComision.DataSource = Comisiones;
            this.cboIdComision.DisplayMember = "ID";
            this.cboIdComision.ValueMember = "ID";

            //traigo las comisiones para el combobox IdMateria
            try
            {
                Materias = new MateriaLogic().GetAll();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Curso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.cboIdMateria.DataSource = Materias;
            this.cboIdMateria.DisplayMember = "ID";
            this.cboIdMateria.ValueMember = "ID";
        }
        public override void MapearDeDatos()
        {
            Curso cur = new CursoLogic().GetOne(this.CursoActual.ID);
            Materia mat = new MateriaLogic().GetOne(this.CursoActual.ID);
            this.txtID.Text = this.CursoActual.ID.ToString();
            this.txtDesc.Text = this.CursoActual.Descripcion;
            this.txtAnioCalendario.Text = this.CursoActual.AnioCalendario.ToString();
            this.cboIdComision.SelectedItem = Comisiones.Find(x => x.ID == CursoActual.IDComision);//cargo la comision seleccionada
            this.cboIdMateria.SelectedItem = Materias.Find(x => x.ID == CursoActual.IDMateria);//cargo la materia seleccionada
            this.txtCupo.Text = this.CursoActual.Cupo.ToString();
            switch (this.Modo)
            {
                case ModoForm.Alta:
                case ModoForm.Modificacion:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    this.btnAceptar.Text = "Eliminar";
                    break;
                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    break;
                default:
                    break;
            }

        }
        public override void MapearADatos()
        {
            if (this.Modo == ModoForm.Alta || this.Modo == ModoForm.Modificacion)
            {
                if (this.Modo == ModoForm.Modificacion)
                {
                    this.CursoActual.ID = int.Parse(this.txtID.Text);
                }
                else
                {
                    this.CursoActual = new Curso();
                }
                int numeroValido;

                if (int.TryParse(this.txtAnioCalendario.Text, out numeroValido))
                    this.CursoActual.AnioCalendario = numeroValido;
                else
                    MessageBox.Show("Ingrese Año Calendario (NUMERO VALIDO)");

                if (int.TryParse(this.txtCupo.Text, out numeroValido))
                    this.CursoActual.Cupo= numeroValido;
                else
                    MessageBox.Show("Ingrese Cupo (NUMERO VALIDO)");

                this.CursoActual.Descripcion = this.txtDesc.Text;
                this.CursoActual.IDComision = ((Comision)this.cboIdComision.SelectedItem).ID;
                this.CursoActual.IDMateria = ((Materia)this.cboIdMateria.SelectedItem).ID;
            }
            switch (this.Modo)
            {
                case ModoForm.Alta:
                    this.CursoActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    this.CursoActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Baja:
                    this.CursoActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Consulta:
                    this.CursoActual.State = BusinessEntity.States.Unmodified;
                    break;
                default:
                    break;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            try
            {
                Business.Logic.CursoLogic cl = new CursoLogic();
                cl.Save(this.CursoActual);
            }
            catch (Exception e)
            {
                this.Notificar(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public override bool Validar()
        {
            bool valido = true;
            string mensaje = "";
            if (txtDesc.Text == "")
            {
                mensaje = mensaje + "Ingrese una descripcion. ";
                valido = false;

            }
            if (txtAnioCalendario.Text == "")
            {
                mensaje = mensaje + "Ingrese un Año calendario. ";
                valido = false;

            }
            if (txtCupo.Text == "")
            {
                mensaje = mensaje + "Ingrese el cupo. ";
                valido = false;
            }

            if (cboIdComision.SelectedIndex == -1)
            {
                mensaje = mensaje + "Seleccione un Id Comisión. ";
                valido = false;
            }

            if (cboIdMateria.SelectedIndex == -1)
            {
                mensaje = mensaje + "Seleccione un Id Materia. ";
                valido = false;
            }
            //despues tendria que ver que el IDPlan exista en la tabla planes--Listo
            if (!valido)
            {
                this.Notificar(mensaje, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return valido;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.Validar())
            {
                this.GuardarCambios();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if (this.Validar())
            {
                this.GuardarCambios();
                this.Close();
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
