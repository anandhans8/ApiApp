using System.Collections.Generic;
using MediatR;
using ApiApp.Application.Reports.Models;

namespace ApiApp.Application.Reports.Queries
{
    public class EmployeesWithManagersQuery : IRequest<IEnumerable<EmployeeManagerModel>>
    {
    }
}
