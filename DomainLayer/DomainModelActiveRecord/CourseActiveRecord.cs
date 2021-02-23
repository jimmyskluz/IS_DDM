using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DomainLayer.DomainModelActiveRecord
{
    public class CourseActiveRecord : ActiveRecord<CourseActiveRecord>, IDentity
    {
        public int idcourse { get; set; }
        public string course_name { get; set; }
        public string difficulty { get; set; }
        public int capacity { get; set; }
        public int lector_idlector { get; set; }
        public int classroom_idclassroom { get; set; }
        public int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public static void AddCourse(string c_name, char c_level, int c_capacity, string c_lector, int c_class, SqlConnection connection)
        {

            string sql = "exec addCourse " + c_name + ", @level, " + c_lector + ", @capacity, @class";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@level", c_level);
                command.Parameters.AddWithValue("@capacity", c_capacity);
                command.Parameters.AddWithValue("@class", c_class);
                command.ExecuteNonQuery();
            }
        }

        public static bool CourseIsValid(string c_name, char c_level, SqlConnection connection)
        {
            string sql = "select * from course where course_name = '" + c_name + "' and difficulty = @level";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@level", c_level);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                        return false;
                }
            }
            return true;
        }

        public static bool ClassroomIsValid(int c_capacity, int c_class, SqlConnection connection)
        {
           
            string sql = "select capacity from classroom where room_number= @number";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@number", c_class);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                        if (reader.GetInt32(0) < c_capacity)
                            return false;
                }
            }
            return true;
        }
    }
}
