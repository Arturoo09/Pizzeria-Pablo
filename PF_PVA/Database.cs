using System.Data.SqlClient;
using System.Linq;

namespace PF_PVA
{
    class Database
    {
        private SqlConnection connection;

        public SqlConnection Conectarse()
        {
            connection = new SqlConnection("server=(local)\\SQLEXPRESS;database=master; Integrated Security = SSPI");
            connection.Open();
            return connection;
        }

        public SqlDataReader LeerBBDD(string campos, string tablas, string condicion)
        {
            connection = Conectarse();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "SELECT " + campos + " FROM " + tablas + " " + condicion + ";";
            SqlDataReader reader = sqlCommand.ExecuteReader();
            return reader;
        }

        public void CerrarConexion()
        {
            connection.Close();
        }

        public bool InsertarBBDD(string tablas, string valores)
        {
            try
            {
                connection = Conectarse();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO " + tablas + " VALUES (" + valores + ");";
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ModificarBBDD(string tablas, string valores, string condicion)
        {
            try
            {
                connection = Conectarse();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "UPDATE " + tablas + " SET " + valores + " " + condicion + ";";
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarFilaBBDD(string tabla, string condicion)
        {
            try
            {
                connection = Conectarse();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "DELETE FROM " + tabla + " " + condicion + ";";
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        } 
    }
}
