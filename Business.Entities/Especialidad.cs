using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Especialidad: BusinessEntity
    {
        private string _descripcion;

        public string Descripcion { get => _descripcion; set => _descripcion = value; }
    }
}