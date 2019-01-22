using MediatR;

namespace ApiApp.Application.Employees.Commands
{
    public class ChangeEmployeesManagerCommand : IRequest
    {
        public int EmployeeId { get; set; }

        public int ManagerId { get; set; }
    }
}
