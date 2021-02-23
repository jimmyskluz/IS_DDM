using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DomainLayer.DomainModelActiveRecord
{
    public class ClassroomActiveRecord : ActiveRecord<ClassroomActiveRecord>, IDentity
    {
        public int idclassroom { get; set; }
        public int capacity { get; set; }
        public int room_number { get; set; }
        public bool with_computers { get; set; }

        public int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public static ClassroomActiveRecord ShowRooms(int capacit, SqlConnection connection)
        {
            ClassroomActiveRecord rooms = Get(capacit);
            string sql = "select * from classroom where capacity > @capacity;";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@capacity", capacit);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rooms = MapResultsetToObject(reader);
                    }
                }
            }
            Add(rooms);

            return rooms;
        }

        private static ClassroomActiveRecord MapResultsetToObject(SqlDataReader reader)
        {
            ClassroomActiveRecord clroom = new ClassroomActiveRecord();
            clroom.idclassroom = reader.GetInt32(0);
            clroom.room_number = reader.GetInt32(1);
            clroom.capacity = reader.GetInt32(2);
            clroom.with_computers = reader.GetBoolean(3);

            return clroom;
        }
    }
}
