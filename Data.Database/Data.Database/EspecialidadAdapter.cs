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
    public class EspecialidadAdapter: Adapter
    {
        public List<Especialidad> GetAll()
        {
            List<Especialidad> especialidades = new List<Especialidad>();

            try
            {
                this.OpenConnection();
                SqlCommand cmdEspecialidades = new SqlCommand("select * from especialidades", SqlConn);
                SqlDataReader drEspecialidades = cmdEspecialidades.ExecuteReader();
                while (drEspecialidades.Read())
                {
                    Especialidad es = new Especialidad();
                    es.ID = (int)drEspecialidades["id_especialidad"];
                    es.Descripcion = (string)drEspecialidades["desc_especialidad"];

                    especialidades.Add(es);
                }
                drEspecialidades.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Especialidades", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

            return especialidades;
        }

        public Business.Entities.Especialidad GetOne(int ID)
        {
            Especialidad es = new Especialidad();
            try
            {
                this.OpenConnection();
                SqlCommand cmdEspecialidades = new SqlCommand("select * from especialidades where id_especialidad = @id", SqlConn);
                cmdEspecialidades.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drEspecialidades = cmdEspecialidades.ExecuteReader();
                if (drEspecialidades.Read())
                {
                    es.ID = (int)drEspecialidades["id_especialidad"];
                    es.Descripcion = (string)drEspecialidades["desc_especialidad"];

                }
                drEspecialidades.Close();
            }
            catch (Exception Ex)
            {

                Exception ExcepcionManejada = new Exception("Error al recuperar datos de especialidades", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return es;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete especialidades where id_especialidad = @id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar especialidad", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

        }
        protected void Update(Especialidad especialidad)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE especialidades SET desc_especialidad = @desc_especialidad WHERE id_especialidad = @id", SqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = especialidad.ID;
                cmdSave.Parameters.Add("@desc_especialidad", SqlDbType.VarChar, 50).Value = especialidad.Descripcion;
               

                cmdSave.ExecuteNonQuery();


            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos de especialidad", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        protected void Insert(Especialidad especialidad)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO especialidades (desc_especialidad) VALUES (@desc_especialidad) select @@identity", SqlConn);


                cmdSave.Parameters.Add("@desc_especialidad", SqlDbType.VarChar, 50).Value = especialidad.Descripcion;
          
                especialidad.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
                //asi se obtiene el ID que asignó la BD automáticamente

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear la especialidad", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public void Save(Especialidad especialidad)
        {
            if (especialidad.State == BusinessEntity.States.New)
            {
                this.Insert(especialidad);
            }
            else if (especialidad.State == BusinessEntity.States.Deleted)
            {
                this.Delete(especialidad.ID);
            }
            else if (especialidad.State == BusinessEntity.States.Modified)
            {
                this.Update(especialidad);
            }
            especialidad.State = BusinessEntity.States.Unmodified;
        }
    }
}
