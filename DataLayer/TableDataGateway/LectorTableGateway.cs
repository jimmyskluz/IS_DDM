using System.Data.SqlClient;
using System.Data;

namespace DataLayer.TableDataGateway
{
    public class LectorTableGateway : TableGateway<LectorTableGateway>
    {
        public static DataTable FindByID(int idL, SqlConnection connection)
        {
            var dataTable = new DataTable();
            using (SqlCommand command = new SqlCommand("select first_name, last_name from lector where idlector = @idL; ", connection))
            {
                command.Parameters.AddWithValue("@idL", idL);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }
            return dataTable;
        }

    }
}
