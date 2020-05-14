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
            return this.UsuarioData.GetAll();
        } 
        public Usuario GetOne (int id)
        {
            return this.UsuarioData.GetOne(id);
        }
        public void Delete (int id)
        {
            this.UsuarioData.Delete(id);
        }
        public void Save (Usuario us)
        {
            this.UsuarioData.Save(us);
        }
    }
}
