using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class EspecialidadLogic : BussinessLogic
    {
        public EspecialidadAdapter EspecialidadData { get; set; }
        public EspecialidadLogic()
        {
            this.EspecialidadData = new EspecialidadAdapter();
        }
        public List<Especialidad> GetAll()
        {
            try
            {
                return this.EspecialidadData.GetAll();
            }
            catch (Exception Ex)
            {

                throw new Exception("No se pudo traer la lista de Especialidades!", Ex);
            }

        }
        public Especialidad GetOne(int id)
        {
            try
            {
                return this.EspecialidadData.GetOne(id);
            }
            catch (Exception Ex)
            {

                throw new Exception("No se pudo traer la Especialidad!", Ex);
            }
        }
        public void Delete(int id)
        {
            try
            {
                this.EspecialidadData.Delete(id);
            }
            catch (Exception Ex)
            {

                throw new Exception("No se pudo eliminar la especialidad", Ex);
            }

        }
        public void Save(Especialidad es)
        {
            try
            {
                this.EspecialidadData.Save(es);
            }
            catch (Exception Ex)
            {

                throw new Exception("No se pudo guardar el plan", Ex);
            }

        }
    }
}
