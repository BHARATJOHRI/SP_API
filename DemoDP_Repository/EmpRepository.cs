using DemoDP_Repository.IRepository;
using DemoSP_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDP_Repository
{
    public class EmpRepository : IEmpRepository
    {
        private readonly IDapperRepository _dapperRepository;
        public EmpRepository(IDapperRepository dapperRepository)
        {
            _dapperRepository = dapperRepository;
        }

        public async Task<List<Employee>> GetEmployee()
        {
            var getSql = "USP_GET_EMP";
            return await _dapperRepository.Execute<Employee>(getSql); 
        }

        public async Task<Employee> GetEMPByID(int id)
        {
            var getSql = "USP_GET_EMPBYID";
            return await _dapperRepository.ExecuteByID<Employee>(getSql,new { ID = id });
        }

        public async Task<int> InsertEmployee(Employee emp)
        {
            var getSql = "USP_INSERT_EMP";
            return await _dapperRepository.InsertQuery<Employee>(getSql,new { NAME = emp.Name,SALARY = emp.Salary });
        }
    }
}