using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSP_DbContext.Interface
{
    public interface IDBContext
    {
        public IDbConnection Connection(string getSql);
    }
}
