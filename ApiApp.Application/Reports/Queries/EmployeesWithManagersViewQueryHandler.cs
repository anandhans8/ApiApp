using Dapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ApiApp.Application.Reports.Models;
using ApiApp.Persistence;

namespace ApiApp.Application.Reports.Queries
{
    public class EmployeesWithManagersViewQueryHandler : IRequestHandler<EmployeesWithManagersViewQuery, IEnumerable<EmployeeManagerModel>>
    {
        private readonly NorthwindDbContext _context;

        public EmployeesWithManagersViewQueryHandler(NorthwindDbContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<EmployeeManagerModel>> Handle(EmployeesWithManagersViewQuery request, CancellationToken cancellationToken)
        {
            var sql = "select * from viewEmployeesWithManagers";

            return _context.Database.GetDbConnection()
                .QueryAsync<EmployeeManagerModel>(sql);
        }
    }
}
