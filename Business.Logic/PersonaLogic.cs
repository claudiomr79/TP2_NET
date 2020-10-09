using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class PersonaLogic: BussinessLogic
    {
        public PersonaAdapter PersonaData { get; set; }

        public PersonaLogic()
        {
            this.PersonaData = new PersonaAdapter();
        }
        public List<Persona> GetAll()
        {
            try
            {
                return this.PersonaData.GetAll();
            }
            catch (Exception Ex)
            {

                throw new Exception("No se pudo traer la lista de Personas!", Ex);
            }

        }
        public Persona GetOne(int id)
        {
            try
            {
                return this.PersonaData.GetOne(id);
            }
            catch (Exception Ex)
            {

                throw new Exception("No se pudo traer la Persona!", Ex);
            }
        }
        public void Delete(int id)
        {
            try
            {
                this.PersonaData.Delete(id);
            }
            catch (Exception Ex)
            {

                throw new Exception("No se pudo eliminar la persona", Ex);
            }

        }
        public void Save(Usuario us)
        {
            try
            {
                this.PersonaData.Save(us);
            }
            catch (Exception Ex)
            {

                throw new Exception("No se pudo guardar la persona", Ex);
            }

        }       
    }
}
