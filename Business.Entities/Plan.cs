using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Plan: BusinessEntity
    {
        private string _descripcion;

        private int _IDEspecialidad;

        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int IDEspecialidad { get => _IDEspecialidad; set => _IDEspecialidad = value; }
    }
}