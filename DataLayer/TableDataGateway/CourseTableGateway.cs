using System;
using System.Data.SqlClient;
using System.Data;

namespace DataLayer.TableDataGateway
{
    public class CourseTableGateway : TableGateway<CourseTableGateway>
    {
        public static DataTable Find(SqlConnection connection)
        {
            var dataTable = new DataTable();
            using (SqlCommand command = new SqlCommand("SELECT * FROM Course;", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }
            return dataTable;
        }

        public static DataTable Insert(string c_name, string c_level, string c_capacity, string c_lector, string c_class, SqlConnection connection)
        {
            var dataTable = new DataTable();
            using (SqlCommand command = new SqlCommand("exec addCourse " + c_name + " " + c_level + " " + c_capacity + " " + c_lector + " " + c_class, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }
            return dataTable;
        }
    }
}

