using AutoMapper;
using DemoDP_Repository.IRepository;
using DemoSP_DataService.Interface;
using DemoSP_Infrastructure.DTO;
using DemoSP_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSP_DataService
{
    public class EmpDataService : IEmpDataService
    {
        private readonly IEmpRepository _empRepository;
        private readonly IMapper _mapper;
        public EmpDataService(IEmpRepository empRepository, IMapper mapper)
        {
            _empRepository= empRepository;
            _mapper = mapper;
        }

        public async Task<List<EmployeeDTO>> GetEmp()
        {
            var reponse = await _empRepository.GetEmployee();
            return _mapper.Map<List<EmployeeDTO>>(reponse);
         }
        public async Task<EmployeeDTO> GetEMPByID(int id)
        {
            var reponse = await _empRepository.GetEMPByID(id
                );
            return _mapper.Map<EmployeeDTO>(reponse);
         }

        public async Task<int> InsertEmp(EmployeeDTO emp)
        {
            var employee = _mapper.Map<Employee>(emp);
            return await _empRepository.InsertEmployee(employee);
        }
    }
}
