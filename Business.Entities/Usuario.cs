using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Usuario : Persona
    {
        private string _nombreUsuario;
        public string NombreUsuario
        {
            get { return _nombreUsuario; }
            set { _nombreUsuario = value; }
        }

        private string _clave;
        public string Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }

        private bool _habilitado;
        public bool Habilitado
        {
            get { return _habilitado; }
            set { _habilitado = value; }
        }
        private bool _cambiaClave;
        public bool CambiaClave
        {
            get { return _cambiaClave; }
            set { _cambiaClave = value; }
        }

        private int _idPersona;
        public int IdPersona
        {
            get { return _idPersona; }
            set { _idPersona = value; }
        }
        //private string _nombre;
        //public string Nombre
        //{
        //    get { return _nombre; }
        //    set { _nombre = value; }
        //}

        //private string _apellido;
        //public string Apellido
        //{
        //    get { return _apellido; }
        //    set { _apellido = value; }
        //}

        //private string _email;
        //public string Email
        //{
        //    get { return _email; }
        //    set { _email = value; }
        //}





    }
}
