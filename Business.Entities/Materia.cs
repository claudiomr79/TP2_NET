using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Materia: BusinessEntity
    {
        private string _descripcion;
        private int _HsSemanales;
        private int _HsTotales;
        private int _IDPlan;

        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int HsSemanales { get => _HsSemanales; set => _HsSemanales = value; }
        public int HsTotales { get => _HsTotales; set => _HsTotales = value; }
        public int IDPlan { get => _IDPlan; set => _IDPlan = value; }
    }
}