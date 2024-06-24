using DemoSP_Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSP_DataService.Interface
{
    public interface IEmpDataService
    {
        public Task<List<EmployeeDTO>> GetEmp();
        public Task<EmployeeDTO> GetEMPByID(int id);
        public Task<int> InsertEmp(EmployeeDTO emp);
    }
}
