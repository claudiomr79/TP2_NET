using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class AlumnoMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["NombreUsuario"] != null)
            {
                string nombreUsuario = (string)Session["NombreUsuario"];
                int idPersona = (int)Session["idPersona"];
                lblNombreUsuario.Text = nombreUsuario;
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
            
        }

        protected void lnbSalir_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("Login.aspx");
        }

        protected void lnbInscripcion_Click(object sender, EventArgs e)
        {
            Response.Redirect("InscripcionAlumno.aspx");
        }
    }
}