using DemoSP_DataService.Interface;
using DemoSP_Infrastructure.DTO;
using DemoSP_Model.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Demo_SP.Controllers
{
    public class EmpController : ControllerBase
    {
        private readonly IEmpDataService _empDataService;
        public EmpController(IEmpDataService empDataService)
        {
            _empDataService = empDataService;
        }
        
        [HttpGet]
        [Route("GetEMP")]
        public async Task<IActionResult> GetEMP()
        {
            var response = await _empDataService.GetEmp();
            return Ok(response);
        }
        [HttpGet]
        [Route("GetEMPByID")]
        public async Task<IActionResult> GetEMPByID(int id)
        {
            var response = await _empDataService.GetEMPByID(id);
            return Ok(response);
        }
        [HttpPost]
        [Route("InsertEMP")]
        public async Task<IActionResult> InsertEMP(EmployeeDTO emp)
        {
            var response = await _empDataService.InsertEmp(emp);
            return Ok(response);
        }

    }
}
