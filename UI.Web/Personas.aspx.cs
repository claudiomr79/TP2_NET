using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace UI.Web
{
    public partial class Personas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cargarTiposPersonas();
                LoadGrid();
            }
        }

        private void cargarTiposPersonas()
        {
            
            ListItem tipo = new ListItem("Alumno","1");
            ddlTipo.Items.Add(tipo);
            ListItem tipo1 = new ListItem("Docente", "2");
            ddlTipo.Items.Add(tipo1);
            ListItem tipo2 = new ListItem("Administrativo", "3");
            ddlTipo.Items.Add(tipo2);

        }

        private void LoadGrid()
        {
            this.gridView.DataSource = this.Logic.GetAll();
            this.gridView.DataBind();
        }

        PersonaLogic _logic;
        public PersonaLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new PersonaLogic();
                }
                return _logic;
            }
        }
#region Propiedades
        public FormModes FormMode
        {
            get { return (FormModes)this.ViewState["FormMode"]; }
            set { this.ViewState["FormMode"] = value; }
        }

        private Persona Entity
        {
            get; set;
        }

        private int SelectedID
        {
            get
            {
                if (this.ViewState["SelectedID"] != null)
                {
                    return (int)this.ViewState["SelectedID"];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                this.ViewState["SelectedID"] = value;
            }
        }

        private bool IsEntitySelected
        {
            get
            {
                return (this.SelectedID != 0);
            }
        }
        #endregion
        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.txtID.Text = this.Entity.ID.ToString();
            this.txtNombre.Text = this.Entity.Nombre;
            this.txtApellido.Text = this.Entity.Apellido;
            this.txtEmail.Text = this.Entity.Email;
            this.txtDireccion.Text = this.Entity.Direccion;
            this.txtFechaNacimiento.Text = this.Entity.FechaFormateada.ToString();
            this.txtIdPlan.Text = this.Entity.IDPlan.ToString();
            this.txtTelefono.Text = this.Entity.Telefono.ToString();
            this.txtLegajo.Text = this.Entity.Legajo.ToString();
            Enum e = this.Entity.TipoPersona;
            this.ddlTipo.SelectedValue = Convert.ToString((int)(object)e);
        }
        private void LoadEntity(Persona persona)
        {
            persona.Nombre = this.txtNombre.Text;
            persona.Apellido = this.txtApellido.Text;
            persona.Email = this.txtEmail.Text;
            persona.Direccion = this.txtDireccion.Text;
            persona.FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
            persona.IDPlan = Convert.ToInt32(txtIdPlan.Text);
            persona.Telefono = this.txtTelefono.Text;
            persona.Legajo = Convert.ToInt32(txtLegajo.Text);
            var tipo = Convert.ToInt32(ddlTipo.SelectedItem.Value);
            switch (tipo)
            {   
                case 1: 
                    persona.TipoPersona = Business.Entities.Persona.TiposPersonas.Alumno;
                    break;
                case 2:
                    persona.TipoPersona = Business.Entities.Persona.TiposPersonas.Docente;
                    break;
                case 3:
                    persona.TipoPersona = Business.Entities.Persona.TiposPersonas.Administrativo;
                    break;
                default:
                    break;
            }
        } 
        private void SaveEntity(Persona persona)
        {
            this.Logic.Save(persona);
        }

        private void EnableForm(bool enable)
        {
            this.txtID.Enabled = false;
            this.txtNombre.Enabled = enable;
            this.txtApellido.Enabled = enable;
            this.txtDireccion.Enabled = enable;
            this.txtEmail.Enabled = enable;
            this.txtFechaNacimiento.Enabled = enable;
            this.txtIdPlan.Enabled = enable;
            this.txtLegajo.Enabled = enable;
            this.txtTelefono.Enabled = enable;
            this.ddlTipo.Enabled = enable;
        }

        private void DeleteEntity(int id)
        {
            this.Logic.Delete(id);
        }

        public enum FormModes
        {
            Alta,
            Baja,
            Modificacion
        }
        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {
            this.EnableForm(true);

            if (this.IsEntitySelected)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.LoadForm(this.SelectedID);
            }
        }



        protected void eliminarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Baja;
                this.EnableForm(false);
                this.LoadForm(this.SelectedID);
            }
        }

        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.EnableForm(true);
        }

        private void ClearForm()
        {
            this.txtID.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtApellido.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtFechaNacimiento.Text = string.Empty;
            this.txtIdPlan.Text = string.Empty;
            this.txtLegajo.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.ddlTipo.SelectedValue = "1";
        }

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case FormModes.Baja:
                    this.DeleteEntity(this.SelectedID);
                    this.LoadGrid();
                    break;
                case FormModes.Modificacion:
                    this.Entity = new Persona();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                case FormModes.Alta:
                    this.Entity = new Persona();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                default:
                    break;
            }

            this.formPanel.Visible = false;
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            this.LoadGrid();
            this.formPanel.Visible = false;
        }

    }
}