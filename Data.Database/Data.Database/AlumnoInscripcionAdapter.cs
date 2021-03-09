using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class AlumnoInscripcionAdapter:Adapter
    {
        public List<AlumnoInscripcion> GetAll()
        {
            List<AlumnoInscripcion> alumnoInscripciones = new List<AlumnoInscripcion>();

            try
            {
                this.OpenConnection();
                SqlCommand cmdAlumnosInscripciones = new SqlCommand("select * from alumnos_inscripciones", SqlConn);
                SqlDataReader drAlumnosInscripciones = cmdAlumnosInscripciones.ExecuteReader();
                while (drAlumnosInscripciones.Read())
                {
                    AlumnoInscripcion alInsc = new AlumnoInscripcion();

                    alInsc.ID = (int)drAlumnosInscripciones["id_inscripcion"];//seria el id_inscripcion del la inscripcion del alumno
                    alInsc.IDAlumno = (int)drAlumnosInscripciones["id_alumno"];
                    alInsc.IDCurso = (int)drAlumnosInscripciones["id_curso"];
                    alInsc.Condicion = (string)drAlumnosInscripciones["condicion"];
                    alInsc.Nota = (int)drAlumnosInscripciones["nota"];

                    alumnoInscripciones.Add(alInsc);
                }
                drAlumnosInscripciones.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista Inscripciones de Alumnos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

            return alumnoInscripciones;
        }

        public Business.Entities.AlumnoInscripcion GetOne(int ID)
        {
            AlumnoInscripcion alInsc = new AlumnoInscripcion();
            try
            {
                this.OpenConnection();
                SqlCommand cmdAlumnosInscripciones = new SqlCommand("select * from alumnos_inscripciones where id_alumno = @id", SqlConn);
                cmdAlumnosInscripciones.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drAlumnosInscripciones = cmdAlumnosInscripciones.ExecuteReader();
                if (drAlumnosInscripciones.Read())
                {
                    alInsc.ID = (int)drAlumnosInscripciones["id_inscripcion"];//seria el id_inscripcion del la inscripcion del alumno
                    alInsc.IDAlumno = (int)drAlumnosInscripciones["id_alumno"];
                    alInsc.IDCurso = (int)drAlumnosInscripciones["id_curso"];
                    alInsc.Condicion = (string)drAlumnosInscripciones["condicion"];
                    alInsc.Nota = (int)drAlumnosInscripciones["nota"];


                }
                drAlumnosInscripciones.Close();
            }
            catch (Exception Ex)
            {

                Exception ExcepcionManejada = new Exception("Error al recuperar datos de Inscripciones de Alumnos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return alInsc;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete alumnos_inscripciones where id_alumno = @id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar la inscripcion del Alumno", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

        }
        protected void Update(AlumnoInscripcion alInsc)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE alumnos_inscripciones SET id_alumno = @id_alumno, id_curso = @id_curso, " +
                    "condicion = @condicion, nota = @nota WHERE id_inscripcion = @id", SqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = alInsc.ID;
                cmdSave.Parameters.Add("@id_alumno", SqlDbType.Int).Value = alInsc.IDAlumno;
                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = alInsc.IDCurso;
                cmdSave.Parameters.Add("@nota", SqlDbType.Int).Value = alInsc.Nota;
                cmdSave.Parameters.Add("@condicion", SqlDbType.VarChar, 50).Value = alInsc.Condicion;
                
                cmdSave.ExecuteNonQuery();


            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos de la Inscripcion del Alumno", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        protected void Insert(AlumnoInscripcion alInsc)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO alumnos_inscripciones (id_alumno, id_curso, condicion, nota) VALUES (@id_alumno,@id_curso,@condicion,@nota) select @@identity", SqlConn);

                cmdSave.Parameters.Add("@id_alumno", SqlDbType.Int).Value = alInsc.IDAlumno;
                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = alInsc.IDCurso;
                cmdSave.Parameters.Add("@condicion", SqlDbType.VarChar, 50).Value = alInsc.Condicion;
                cmdSave.Parameters.Add("@nota", SqlDbType.Int).Value = alInsc.Nota;
                
                alInsc.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
                //asi se obtiene el ID que asignó la BD automáticamente

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear la inscripcion del Alumno", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public void Save(AlumnoInscripcion alumnoInscripcion)
        {
            if (alumnoInscripcion.State == BusinessEntity.States.New)
            {
                this.Insert(alumnoInscripcion);
            }
            else if (alumnoInscripcion.State == BusinessEntity.States.Deleted)
            {
                this.Delete(alumnoInscripcion.ID);
            }
            else if (alumnoInscripcion.State == BusinessEntity.States.Modified)
            {
                this.Update(alumnoInscripcion);
            }
            alumnoInscripcion.State = BusinessEntity.States.Unmodified;
        }
    }
}
