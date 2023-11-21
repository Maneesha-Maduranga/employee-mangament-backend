using employee_mangment_backend.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace employee_mangment_backend.Controllers
{
    [ApiController]
    [Route("/api/employees")]
    public class EmployeeController : Controller
    {

        private readonly EmployeeContext _employeecontext;
        public EmployeeController(EmployeeContext employeeContext)
        {
            _employeecontext = employeeContext;
        }


        [HttpGet]
        public async Task<IActionResult> getAllEmployees()
        {
            var employees =  await  _employeecontext.Employees.ToListAsync();
            return Ok(employees);
        }
    }
}
