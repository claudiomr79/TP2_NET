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
    public partial class ComisionDesktop : ApplicationForm
    {
        public Business.Entities.Comision ComisionActual { get; set; }
        private List<Plan> Planes { get; set; }
        public ComisionDesktop()
        {
            InitializeComponent();

            //traigo los planes para el combobox
            try
            {
                Planes = new PlanLogic().GetAll();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Comision", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.cbxIdPlan.DataSource = Planes;
            this.cbxIdPlan.DisplayMember = "IDEspecialidad";
            this.cbxIdPlan.ValueMember = "IDEspecialidad";
        }
        public ComisionDesktop(ModoForm modo) : this()
        {
            this.Modo = modo; //para altas
        }
        public ComisionDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            ComisionLogic comision = new ComisionLogic();
            ComisionActual = comision.GetOne(ID);
            
            MapearDeDatos();
        }
       
        public override void MapearDeDatos()
        {
            Comision comi = new ComisionLogic().GetOne(this.ComisionActual.ID);
            this.txtID.Text = this.ComisionActual.ID.ToString();
            this.txtDescripcion.Text = this.ComisionActual.Descripcion;
            this.txtAnioEspecialidad.Text = this.ComisionActual.AnioEspecialidad.ToString();
            this.cbxIdPlan.SelectedItem = Planes.Find(x => x.ID == comi.IDPlan);//cargo el plan seleccionado

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
                    this.ComisionActual.ID = int.Parse(this.txtID.Text);
                }
                else
                {
                    this.ComisionActual = new Comision();
                }
                int numeroValido;
               
                if (int.TryParse(this.txtAnioEspecialidad.Text, out numeroValido))
                    this.ComisionActual.AnioEspecialidad = numeroValido;
                else
                    MessageBox.Show("Ingrese Año de Especialidad (NUMERO VALIDO)");

                

                this.ComisionActual.Descripcion = this.txtDescripcion.Text;
                this.ComisionActual.IDPlan = ((Plan)this.cbxIdPlan.SelectedItem).ID;

            }
            switch (this.Modo)
            {
                case ModoForm.Alta:
                    this.ComisionActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    this.ComisionActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Baja:
                    this.ComisionActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Consulta:
                    this.ComisionActual.State = BusinessEntity.States.Unmodified;
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
                Business.Logic.ComisionLogic cl = new ComisionLogic();
                cl.Save(this.ComisionActual);
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
            if (txtAnioEspecialidad.Text == "")
            {
                mensaje = mensaje + "Ingrese Año de especialidad. ";
                valido = false;
            }

            if (cbxIdPlan.SelectedIndex == -1)
            {
                mensaje = mensaje + "Seleccione un Plan. ";
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
    }
}
