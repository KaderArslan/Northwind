using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using Northwind.WebApi.Base;

namespace Northwind.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ApiBaseController<IEmployeeService, Employee, DtoEmployee>
    {
        private readonly IEmployeeService employeeService;
        public EmployeeController(IEmployeeService employeeService) : base(employeeService)
        {
            this.employeeService = employeeService;
        }
    }
}
