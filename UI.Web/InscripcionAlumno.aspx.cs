﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace UI.Web
{
    public partial class InscripcionAlumno : System.Web.UI.Page
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
       
    }
}