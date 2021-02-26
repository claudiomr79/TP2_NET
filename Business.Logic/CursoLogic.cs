using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class CursoLogic: BussinessLogic
    {
        public CursoAdapter CursoData { get; set; }

        public CursoLogic()
        {
            this.CursoData = new CursoAdapter();
        }
        public List<Curso> GetAll()
        {
            try
            {
                return this.CursoData.GetAll();
            }
            catch (Exception Ex)
            {

                throw new Exception("No se pudo traer la lista de Cursos!", Ex);
            }

        }
        public Curso GetOne(int id)
        {
            try
            {
                return this.CursoData.GetOne(id);
            }
            catch (Exception Ex)
            {

                throw new Exception("No se pudo traer el curso!", Ex);
            }
        }
        public void Delete(int id)
        {
            try
            {
                this.CursoData.Delete(id);
            }
            catch (Exception Ex)
            {

                throw new Exception("No se pudo eliminar el curso", Ex);
            }

        }
        public void Save(Curso curso)
        {
            try
            {
                this.CursoData.Save(curso);
            }
            catch (Exception Ex)
            {

                throw new Exception("No se pudo guardar el curso", Ex);
            }

        }
    }
}
