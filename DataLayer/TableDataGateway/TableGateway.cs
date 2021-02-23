using System;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer.TableDataGateway
{
    public abstract class TableGateway<T>
    {
        public static DataTable Find(SqlConnection connection) { throw new NotImplementedException(); }

    }
}
