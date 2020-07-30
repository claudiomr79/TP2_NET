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
    public partial class MateriaDesktop : ApplicationForm
    {
        public Business.Entities.Materia MateriaActual { get; set; }
        public MateriaDesktop(ModoForm modo) : this()
        {
            this.Modo = modo; //para altas
        }
        public MateriaDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            MateriaLogic materia = new MateriaLogic();
            MateriaActual = materia.GetOne(ID);
            MapearDeDatos();
        }
        public MateriaDesktop()
        {
            InitializeComponent();
        }
        public override void MapearDeDatos()
        {
            this.txtID.Text = this.MateriaActual.ID.ToString();
            this.txtDescripcion.Text = this.MateriaActual.Descripcion;
            this.txtHsSemanales.Text = this.MateriaActual.HsSemanales.ToString();
            this.txtHsTotales.Text = this.MateriaActual.HsTotales.ToString();
            this.txtIdPlan.Text = this.MateriaActual.IDPlan.ToString();

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
                    this.MateriaActual.ID = int.Parse(this.txtID.Text);
                }
                else
                {
                    this.MateriaActual = new Materia();
                }
                int numeroValido;
                this.MateriaActual.Descripcion = this.txtDescripcion.Text;
                if (int.TryParse(this.txtHsSemanales.Text, out numeroValido))
                    this.MateriaActual.HsSemanales = numeroValido;
                else
                    MessageBox.Show("Ingrese horas Semanales (NUMERO VALIDO)");
                if (int.TryParse(this.txtHsTotales.Text, out numeroValido))
                    this.MateriaActual.HsTotales = numeroValido;
                else
                    MessageBox.Show("Ingrese horas Totales (NUMERO VALIDO)");
                if (int.TryParse(this.txtIdPlan.Text, out numeroValido))
                    this.MateriaActual.IDPlan = numeroValido;
                else
                    MessageBox.Show("Ingrese ID Plan (NUMERO VALIDO)");

            }
            switch (this.Modo)
            {
                case ModoForm.Alta:
                    this.MateriaActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    this.MateriaActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Baja:
                    this.MateriaActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Consulta:
                    this.MateriaActual.State = BusinessEntity.States.Unmodified;
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
                Business.Logic.MateriaLogic ml = new MateriaLogic();
                ml.Save(this.MateriaActual);
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
            if (txtHsSemanales.Text =="")
            {
                mensaje = mensaje + "Ingrese Hs semanales. ";
                valido = false;
            }
            if (txtHsTotales.Text == "")
            {
                mensaje = mensaje + "Ingrese Hs totales. ";
                valido = false;
            }
            if (txtHsSemanales.Text == "")
            {
                mensaje = mensaje + "Ingrese Hs semanales. ";
                valido = false;
            }
            if (txtIdPlan.Text == "")
            {
                mensaje = mensaje + "Ingrese Un ID Plan. ";
                valido = false;
            }

            //despues tendria que ver que el IDPlan exista en la tabla planes
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
