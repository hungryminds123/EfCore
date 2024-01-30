using Core.Interfaces;
using Core.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EFCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService service)
        {
           _employeeService = service;
        }


        [HttpGet]
        public async Task<IEnumerable<EmployeeViewModel>> Get()
        {
            var data = await _employeeService.GetAllEmployees();

            return data;
        }
    }
}
