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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
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

       

        protected void btnLoguearse_Click(object sender, EventArgs e)
        {
            string nombreUsuario, password;
            nombreUsuario = this.txtNombreUsuario.Text;
            password = this.txtPassword.Text;
            bool usuarioLogueado = this.Logic.ValidarUsuarioLogic(nombreUsuario, password);
            if (usuarioLogueado)
            {
                Response.Redirect("Default.aspx");
            }
            else
            {
                lblLogIn.Visible = true;
                lblLogIn.Text = "Usuario/contraseña Invalida!!";
                               
               // Response.Redirect("Login.aspx");
            }
        }
    }
}