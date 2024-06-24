using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSP_DbContext
{
    public class SqlDBContext
    {
        private SqlConnection connection;
        public SqlDBContext(string? connectionString)
        {
            connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
        }
        public SqlConnection Connection
        {
            get { return connection; }
        }

        public void Dispose()
        {
            connection.Close();
        }
    }
}

