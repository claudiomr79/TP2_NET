using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class PlanLogic: BussinessLogic
    {
        public PlanAdapter PlanData { get; set; }
        public PlanLogic()
        {
            this.PlanData = new PlanAdapter();
        }
        public List<Plan> GetAll()
        {
            try
            {
                return this.PlanData.GetAll();
            }
            catch (Exception Ex)
            {

                throw new Exception("No se pudo traer la lista de planes!", Ex);
            }

        }
        public Plan GetOne(int id)
        {
            try
            {
                return this.PlanData.GetOne(id);
            }
            catch (Exception Ex)
            {

                throw new Exception("No se pudo traer el plan!", Ex);
            }
        }
        public void Delete(int id)
        {
            try
            {
                this.PlanData.Delete(id);
            }
            catch (Exception Ex)
            {

                throw new Exception("No se pudo eliminar al plan", Ex);
            }

        }
        public void Save(Plan us)
        {
            try
            {
                this.PlanData.Save(us);
            }
            catch (Exception Ex)
            {

                throw new Exception("No se pudo guardar el plan", Ex);
            }

        }

    }
}
