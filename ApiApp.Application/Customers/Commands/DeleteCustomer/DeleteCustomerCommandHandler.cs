using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ApiApp.Application.Exceptions;
using ApiApp.Domain.Entities;
using ApiApp.Persistence;

namespace ApiApp.Application.Customers.Commands.DeleteCustomer
{
    public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommand>
    {
        private readonly NorthwindDbContext _context;

        public DeleteCustomerCommandHandler(NorthwindDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Customers
                .FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Customer), request.Id);
            }

            var hasOrders = _context.Orders.Any(o => o.CustomerId == entity.CustomerId);
            if (hasOrders)
            {
                throw new DeleteFailureException(nameof(Customer), request.Id, "There are existing orders associated with this customer.");
            }

            _context.Customers.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
