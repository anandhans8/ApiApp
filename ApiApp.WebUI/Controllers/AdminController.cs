using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApiApp.Application.Employees.Commands;
using ApiApp.Application.Employees.Models;
using ApiApp.Application.Employees.Queries;

namespace ApiApp.WebUI.Controllers
{
    public class AdminController : BaseController
    {
        [HttpGet]
        public Task<IEnumerable<EmployeeManagerModel>> EmployeeManagerReport()
        {
            return Mediator.Send(new EmployeesWithManagersQuery());
        }

        [HttpPost]
        public IActionResult ChangeEmployeeManager(ChangeEmployeesManagerCommand command)
        {
            Mediator.Send(command);

            return NoContent();
        }
    }
}
