using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class UsuarioLogic: BussinessLogic
    {
        public UsuarioAdapter UsuarioData { get; set; }

        public UsuarioLogic()
        {   
            this.UsuarioData = new UsuarioAdapter();
        }
        public List<Usuario> GetAll()
        {
            try
            {
                return this.UsuarioData.GetAll();
            }
            catch (Exception Ex)
            {

                throw new Exception("No se pudo traer la lista de usuarios!", Ex);
            }
           
        } 
        public Usuario GetOne (int id)
        {
            try
            {
                return this.UsuarioData.GetOne(id);
            }
            catch (Exception Ex)
            {

                throw new Exception ("No se pudo traer el usuario!", Ex);
            }
        }
        public void Delete (int id)
        {
            try
            {
                this.UsuarioData.Delete(id);
            }
            catch (Exception Ex)
            {

                throw new Exception ("No se pudo eliminar al usuario", Ex);
            }
            
        }
        public void Save (Usuario us)
        {
            try
            {
                this.UsuarioData.Save(us);
            }
            catch (Exception Ex)
            {

                throw new Exception ("No se pudo guardar el usuario", Ex);
            }
            
        }
    }
}
