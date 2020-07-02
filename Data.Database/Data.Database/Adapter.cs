using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace Data.Database
{
    public class Adapter
    {
        //private SqlConnection sqlConnection = new SqlConnection("ConnectionString;");
        //Clave por defecto a utlizar para la cadena de conexion
        const string consKeyDefaultCnnString = "ConnStringLocal";

        public SqlConnection sqlConn { get; set; }

        protected void OpenConnection()
        {
            sqlConn = new SqlConnection (ConfigurationManager.ConnectionStrings[consKeyDefaultCnnString].ConnectionString);
            this.sqlConn.Open();
        }

        protected void CloseConnection()
        {
            this.sqlConn.Close();
            sqlConn = null;
        }

        protected SqlDataReader ExecuteReader(String commandText)
        {
            throw new Exception("Metodo no implementado");
        }
    }
}
