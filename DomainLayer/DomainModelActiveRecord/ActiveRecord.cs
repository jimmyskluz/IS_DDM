using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DomainLayer.DomainModelActiveRecord
{
    public abstract class ActiveRecord<T> : IdentityMap<T> where T : IDentity
    {
        public static T Find(int id, SqlConnection connection) { throw new NotImplementedException(); }
        public static T MapResultsetToObject(SqlDataReader reader) { throw new NotImplementedException(); }
        public static void Update(T updatedT, SqlConnection connection) { throw new NotImplementedException(); }
    }
}
