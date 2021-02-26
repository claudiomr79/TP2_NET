using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class ComisionLogic: BussinessLogic
    {
        public ComisionAdapter ComisionData { get; set; }
        public ComisionLogic()
        {
            this.ComisionData = new ComisionAdapter();
        }
        public List<Comision> GetAll()
        {
            try
            {
                return this.ComisionData.GetAll();
            }
            catch (Exception Ex)
            {
                throw new Exception("No se pudo traer la lista de Comisiones!", Ex);
            }

        }
        public Comision GetOne(int id)
        {
            try
            {
                return this.ComisionData.GetOne(id);
            }
            catch (Exception Ex)
            {
                throw new Exception("No se pudo traer la Comision!", Ex);
            }
        }
        public void Delete(int id)
        {
            try
            {
                this.ComisionData.Delete(id);
            }
            catch (Exception Ex)
            {
                throw new Exception("No se pudo eliminar la Comision", Ex);
            }

        }
        public void Save(Comision com)
        {
            try
            {
                this.ComisionData.Save(com);
            }
            catch (Exception Ex)
            {
                throw new Exception("No se pudo guardar la Comision", Ex);
            }

        }

        
    }
}
