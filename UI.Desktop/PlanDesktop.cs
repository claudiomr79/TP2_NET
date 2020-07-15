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
    public partial class PlanDesktop : ApplicationForm
    {
        public Business.Entities.Plan PlanActual { get; set; }
        public PlanDesktop(ModoForm modo) : this()
        {
            this.Modo = modo; //para altas
        }
        public PlanDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            PlanLogic plan = new PlanLogic();
            PlanActual = plan.GetOne(ID);
            MapearDeDatos();
        }
        public PlanDesktop()
        {
            InitializeComponent();
        }
        public override void MapearDeDatos()
        {
            this.txtID.Text = this.PlanActual.ID.ToString();
            this.txtDescripcion.Text = this.PlanActual.Descripcion;
            this.txtIdEspecialidad.Text = this.PlanActual.IDEspecialidad.ToString();
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
                    this.PlanActual.ID = int.Parse(this.txtID.Text);
                }
                else
                {
                    this.PlanActual = new Plan();
                }

                this.PlanActual.Descripcion = this.txtDescripcion.Text;
                this.PlanActual.IDEspecialidad = int.Parse(this.txtIdEspecialidad.Text);
                
            }
            switch (this.Modo)
            {
                case ModoForm.Alta:
                    this.PlanActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    this.PlanActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Baja:
                    this.PlanActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Consulta:
                    this.PlanActual.State = BusinessEntity.States.Unmodified;
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
                Business.Logic.PlanLogic pl = new PlanLogic();
                pl.Save(this.PlanActual);
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
            if (txtDescripcion.Text == "")
            {
                mensaje = mensaje + "Ingrese una descripcion. ";
                valido = false;

            }
            //despues tendria que ver que el IDEspecialidad exista en la tabla especialidad
            if (txtIdEspecialidad.Text == "")
            {
                mensaje = mensaje + "Ingrese un Id Especialidad. ";
                valido = false;
            }
            
           
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



    }


      
 }

