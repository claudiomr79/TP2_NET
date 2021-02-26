using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class AlumnoInscripcion: BusinessEntity
    {
        #region Atributos
        private string _condicion;
        private int _IDAlumno;
        private int _IDCurso;
        private int _nota;
        #endregion

        #region Propiedades
        public string Condicion
        {
            get { return _condicion; }
            set { _condicion = value; }
        }

        public int IDAlumno
        {
            get { return _IDAlumno; }
            set { _IDAlumno = value; }
        }

        public int IDCurso
        {
            get { return _IDCurso; }
            set { _IDCurso = value; }
        }

        public int Nota
        {
            get { return _nota; }
            set { _nota = value; }
        } 
        #endregion
    }
}