using System.Collections.Generic;

namespace ApiApp.Application.Customers.Queries.GetCustomersList
{
    public class CustomersListViewModel
    {
        public IList<CustomerLookupModel> Customers { get; set; }
    }
}
