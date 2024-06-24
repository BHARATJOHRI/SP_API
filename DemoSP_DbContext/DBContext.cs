using DemoSP_DbContext.Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSP_DbContext
{
    public class DBContext : IDBContext
    {
        private IDbConnection _connection;
        private readonly IConfiguration _configuration;

        // Inject IConfiguration through constructor
        public DBContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IDbConnection Connection(string getSql)
        {
            AppDBContext db = new AppDBContext();
            db.ConnectionString = _configuration.GetConnectionString("ConStr");
            _connection = new SqlDBContext(db.ConnectionString).Connection;
            return _connection;
        }
    }
}
