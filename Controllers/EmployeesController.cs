using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cms.Data;
using Cms.Data.DataModels;
using Cms.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gms.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {

        public IEmployeeService EmployeeService { get; set; }

        public EmployeesController(IEmployeeService employeesService) {
            this.EmployeeService = employeesService;
        }
        [HttpGet("list")]
        // GET: Employees
        public List<Employee> Index()
        {

            return this.EmployeeService.GetEmpoyees();
        }

        [HttpGet("search")]
        // GET: Employees by search criteria
        public List<EmployeeViewModel> Search(string key)
        {
            return this.EmployeeService.SearchEmployees(key);
        }

        // GET: Employees/Create
                      
    }
}