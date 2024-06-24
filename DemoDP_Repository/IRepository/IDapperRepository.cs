using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDP_Repository.IRepository
{
    public interface IDapperRepository
    {
        public Task<List<T>> Execute<T>(string getSql);
        public Task<T> ExecuteByID<T>(string getSql, Object parameter);
        public Task<int> InsertQuery<T>(string getSql,Object parameter);

    }
}
