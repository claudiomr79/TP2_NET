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
    public partial class UsuarioDesktop : ApplicationForm
    {
        public Business.Entities.Usuario UsuarioActual { get; set; }
        public UsuarioDesktop(ModoForm modo) : this()
        {
            this.Modo = modo; //para altas
        }
        public UsuarioDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            UsuarioLogic usuario = new UsuarioLogic();
            UsuarioActual = usuario.GetOne(ID);
            MapearDeDatos();
        }
        public UsuarioDesktop()
        {
            InitializeComponent();
        }
        public override void MapearDeDatos()
        {
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtNombre.Text = this.UsuarioActual.Nombre;
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            this.txtEmail.Text = this.UsuarioActual.Email;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            this.txtClave.Text = this.UsuarioActual.Clave;
            this.txtConfirmarClave.Text = this.UsuarioActual.Clave;
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
                    this.UsuarioActual.ID = int.Parse(this.txtID.Text);
                }
                else
                {
                    this.UsuarioActual = new Usuario();
                }

                this.UsuarioActual.Nombre = this.txtNombre.Text;
                this.UsuarioActual.Apellido = this.txtApellido.Text;
                this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                this.UsuarioActual.Clave = this.txtClave.Text;
                this.UsuarioActual.Email = this.txtEmail.Text;
            }
            switch (this.Modo)
            {
                case ModoForm.Alta:
                    this.UsuarioActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    this.UsuarioActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Baja:
                    this.UsuarioActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Consulta:
                    this.UsuarioActual.State = BusinessEntity.States.Unmodified;
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
               Business.Logic.UsuarioLogic us = new UsuarioLogic(); 
               us.Save(this.UsuarioActual);
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
            if (txtNombre.Text == "")
            {
                mensaje = mensaje + "Ingrese un Nombre. ";
                valido = false;
               
            }
            if (txtApellido.Text == "")
            {
                mensaje = mensaje + "Ingrese un Apellido. ";
                valido = false;
            }
            if (txtUsuario.Text == "")
            {
                mensaje = mensaje + "Ingrese un Usuario. ";
                valido = false;
            }
            if (txtClave.Text == "")
            {
                mensaje = mensaje + "Ingrese una Clave. ";
                valido = false;
            }
            if (txtClave.Text != txtConfirmarClave.Text)
            {
                mensaje = mensaje + "Las claves no coinciden. ";
                valido = false;
            }
            if (txtClave.Text.Length < 8 && this.Modo != ModoForm.Baja)
            {
                mensaje = mensaje + "La clave debe tener al menos 8 digitos. ";
                valido = false;
            }
            if (!(txtEmail.Text.Contains("@") && txtEmail.Text.Contains(".com")))
            {
                mensaje = mensaje + "El email no tiene el formato necesario!";
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
