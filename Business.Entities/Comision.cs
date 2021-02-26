using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Comision: BusinessEntity
    {
        #region Atributos
        private string _descripcion;
        private int _IDPlan;
        private int _anioEspecialidad;
        #endregion
        #region Propiedades
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        public int IDPlan
        {
            get { return _IDPlan; }
            set { _IDPlan = value; }
        }
        public int AnioEspecialidad
        {
            get { return _anioEspecialidad; }
            set { _anioEspecialidad = value; }
        } 
        #endregion
    }
}