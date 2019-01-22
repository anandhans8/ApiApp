using MediatR;

namespace ApiApp.Application.Customers.Queries.GetCustomersList
{
    public class GetCustomersListQuery : IRequest<CustomersListViewModel>
    {
    }
}
