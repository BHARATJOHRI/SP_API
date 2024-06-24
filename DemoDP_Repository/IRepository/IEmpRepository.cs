using DemoSP_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDP_Repository.IRepository
{
    public interface IEmpRepository
    {
        public Task<List<Employee>> GetEmployee();
        public Task<Employee> GetEMPByID(int id);
        public Task<int> InsertEmployee(Employee emp);
    }
}
