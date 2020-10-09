using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Persona: BusinessEntity
    {
        #region ATRIBUTOS
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private string _email;
        private string _telefono;
        private DateTime _fechaNacimiento;
        private int _IDPlan;
        private int _legajo;            
        private TiposPersonas _tipoPersona; 
        #endregion

        #region PROPIEDADES
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Email { get => _email; set => _email = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public int IDPlan { get => _IDPlan; set => _IDPlan = value; }
        public int Legajo { get => _legajo; set => _legajo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public int TipoPersona { get; set; }
        #endregion

        enum TiposPersonas
        {
            Alumno=1,
            Docente,
            Administrativo
        }

    }
}