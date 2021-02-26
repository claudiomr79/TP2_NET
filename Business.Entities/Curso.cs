using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Curso: BusinessEntity
    {
        #region Atributos
        private int _anioCalendario;
        private int _cupo;
        private string _descripcion;
        private int _IDComision;
        private int _IDMateria;
        #endregion

        #region Propiedades
        public int AnioCalendario
        {
            get { return _anioCalendario; }
            set { _anioCalendario = value; }
        }

        public int Cupo
        {
            get { return _cupo; }
            set { _cupo = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }

        }

        public int IDComision
        {
            get { return _IDComision; }
            set { _IDComision = value; }
        }

        public int IDMateria
        {
            get { return _IDMateria; }
            set { _IDMateria = value; }
        } 
        #endregion
    }
}