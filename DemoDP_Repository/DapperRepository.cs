using Dapper;
using DemoDP_Repository.IRepository;
using DemoSP_DbContext.Interface;
using System.Collections.Generic;
using System.Data;

namespace DemoDP_Repository
{
    public class DapperRepository : IDapperRepository
    {
        private readonly IDBContext _dBContext;
        public DapperRepository(IDBContext dBContext)
        {
            _dBContext = dBContext;
        }
        public async Task<List<T>> Execute<T>(string getSql)
        {
            using (IDbConnection conn = _dBContext.Connection(getSql))
            {
                return (List<T>)await conn.QueryAsync<T>(getSql);

            }
        }

        public async Task<T> ExecuteByID<T>(string getSql, Object parameter)
        {
            using (IDbConnection conn = _dBContext.Connection(getSql))
            {
                return await conn.QueryFirstOrDefaultAsync<T>(getSql,parameter);

            }
        }

        public async Task<int> InsertQuery<T>(string getSql, object parameter)
        {
            int entityId = 0;
            using (IDbConnection conn = _dBContext.Connection(getSql))
            {
                entityId = await conn.ExecuteScalarAsync<int>(getSql, parameter);
            }
            return entityId;
        }
    }
}
