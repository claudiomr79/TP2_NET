using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;



namespace Business.Logic
{
    public class MateriaLogic: BussinessLogic
    {
        public MateriaAdapter MateriaData { get; set; }
        public MateriaLogic()
        {
            this.MateriaData = new MateriaAdapter();
        }
        public List<Materia> GetAll()
        {
            try
            {
                return this.MateriaData.GetAll();
            }
            catch (Exception Ex)
            {
                
                throw new Exception("No se pudo traer la lista de materias!", Ex);
            }

        }
        public Materia GetOne(int id)
        {
            try
            {
                return this.MateriaData.GetOne(id);
            }
            catch (Exception Ex)
            {

                throw new Exception("No se pudo traer la materia!", Ex);
            }
        }
        public void Delete(int id)
        {
            try
            {
                this.MateriaData.Delete(id);
            }
            catch (Exception Ex)
            {

                throw new Exception("No se pudo eliminar la materia", Ex);
            }

        }
        public void Save(Materia ma)
        {
            try
            {
                this.MateriaData.Save(ma);
            }
            catch (Exception Ex)
            {
                
                throw new Exception("No se pudo guardar la materia", Ex);
            }

        }

    }
}
