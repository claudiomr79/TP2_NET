using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;


namespace UI.Web
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cargarIdPersonas();
                LoadGrid();
            }
        }
        PersonaLogic _logicPersona;
        public PersonaLogic LogicPersona
        {
            get
            {
                if (_logicPersona == null)
                {
                    _logicPersona = new PersonaLogic();
                }
                return _logicPersona;
            }
        }
        private void cargarIdPersonas()
        {
            
            List<Persona> personas = this.LogicPersona.GetAll();
            ddlIdPersona.Items.Insert(0, new ListItem("Seleccionar", "0"));
            foreach(Persona per in personas)
            {
                ddlIdPersona.Items.Add(per.ID.ToString());
            }
            
        }

        UsuarioLogic _logic;
        public UsuarioLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new UsuarioLogic();
                }
                return _logic;
            }
        }
        private void LoadGrid()
        {
            this.gridView.DataSource = this.Logic.GetAll();
            this.gridView.DataBind();
        }

        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            //if (this.FormMode == FormModes.Alta)
                    this.ddlIdPersona.SelectedValue = this.Entity.ID.ToString();
            this.lblNombre.Text = this.Entity.Nombre;
            this.lblApellido.Text = this.Entity.Apellido;
            this.lblEmail.Text = this.Entity.Email;
            this.habilitadoCheckBox.Checked = this.Entity.Habilitado;
            this.nombreUsuarioTextBox.Text = this.Entity.NombreUsuario;
            this.claveTextBox.Text= this.Entity.Clave;
            this.repetirClaveTextBox.Text = this.Entity.Clave;
        }

        private void LoadEntity(Usuario usuario)
        {
            usuario.ID = Convert.ToInt32(ddlIdPersona.SelectedItem.Value);
            usuario.Nombre = this.lblNombre.Text;
            usuario.Apellido = this.lblApellido.Text;
            usuario.Email = this.lblEmail.Text;
            usuario.NombreUsuario = this.nombreUsuarioTextBox.Text;
            usuario.Habilitado = this.habilitadoCheckBox.Checked;
            usuario.Clave = this.claveTextBox.Text;
            
        }
        private void SaveEntity(Usuario usuario)
        {
            this.Logic.Save(usuario);
        }
        
        private void EnableForm (bool enable)
        {
            
            this.lblNombre.Enabled = enable;
            this.lblApellido.Enabled = enable;
            this.lblEmail.Enabled = enable;
            this.nombreUsuarioTextBox.Enabled = enable;
            this.claveTextBox.Visible = enable;
            this.claveLabel.Visible = enable;
            this.repetirClaveTextBox.Visible = enable;
            this.repetirClaveLabel.Visible = enable;
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

        #region Propiedades
        public FormModes FormMode
        {
            get { return (FormModes)this.ViewState["FormMode"]; }
            set { this.ViewState["FormMode"] = value; }
        }

        private Usuario Entity
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

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {
            this.EnableForm(true);
            this.ddlIdPersona.Enabled = false;
            if (this.IsEntitySelected)
            {
                this.formPanel.Visible = true;
                ClearForm();
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
                this.ddlIdPersona.Enabled = false;
                this.LoadForm(this.SelectedID);
            }
        }

        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.ddlIdPersona.Enabled = true;
            this.EnableForm(true);
            

        }

        private void ClearForm()
        {
            this.ddlIdPersona.SelectedIndex = -1;
            this.lblNombre.Text = string.Empty;
            this.lblApellido.Text = string.Empty;
            this.lblEmail.Text = string.Empty;
            this.habilitadoCheckBox.Checked = false;
            this.nombreUsuarioTextBox.Text = string.Empty;
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
                    this.Entity = new Usuario();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                case FormModes.Alta:
                    this.Entity = new Usuario();
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

        protected void ddlIdPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            int id = Convert.ToInt32(ddlIdPersona.SelectedValue);
            persona= this.LogicPersona.GetOne(id);
            lblApellido.Text = persona.Apellido;
            lblNombre.Text = persona.Nombre;
            lblEmail.Text = persona.Email;
        }
    }
}