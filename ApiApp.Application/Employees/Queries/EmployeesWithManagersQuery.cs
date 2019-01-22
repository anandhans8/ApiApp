using System.Collections.Generic;
using MediatR;
using ApiApp.Application.Employees.Models;

namespace ApiApp.Application.Employees.Queries
{
    public class EmployeesWithManagersQuery : IRequest<IEnumerable<EmployeeManagerModel>>
    {
    }
}
