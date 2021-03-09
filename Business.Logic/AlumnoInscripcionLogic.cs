using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class AlumnoInscripcionLogic:BussinessLogic
    {
        public AlumnoInscripcionAdapter AlumnoInscripcionData { get; set; }
        public AlumnoInscripcionLogic()
        {
            this.AlumnoInscripcionData = new AlumnoInscripcionAdapter();
        }
        public List<AlumnoInscripcion> GetAll()
        {
            try
            {
                return this.AlumnoInscripcionData.GetAll();
            }
            catch (Exception Ex)
            {
                throw new Exception("No se pudo traer la lista de Inscripciones de Alumnos!", Ex);
            }

        }
        public AlumnoInscripcion GetOne(int id)
        {
            try
            {
                return this.AlumnoInscripcionData.GetOne(id);
            }
            catch (Exception Ex)
            {
                throw new Exception("No se pudo traer la Inscripción del Alumno!", Ex);
            }
        }
        public void Delete(int id)
        {
            try
            {
                this.AlumnoInscripcionData.Delete(id);
            }
            catch (Exception Ex)
            {
                throw new Exception("No se pudo eliminar la la Inscripción del Alumno", Ex);
            }

        }
        public void Save(AlumnoInscripcion al)
        {
            try
            {
                this.AlumnoInscripcionData.Save(al);
            }
            catch (Exception Ex)
            {
                throw new Exception("No se pudo guardar la la Inscripción del Alumno", Ex);
            }

        }

    }
}
