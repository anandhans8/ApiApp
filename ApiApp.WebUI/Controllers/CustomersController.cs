using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ApiApp.Application.Customers.Queries.GetCustomersList;
using ApiApp.Application.Customers.Queries.GetCustomerDetail;
using ApiApp.Application.Customers.Commands.UpdateCustomer;
using ApiApp.Application.Customers.Commands.CreateCustomer;
using ApiApp.Application.Customers.Commands.DeleteCustomer;
using System.Net;

namespace ApiApp.WebUI.Controllers
{
    public class CustomersController : BaseController
    {
        // GET api/customers
        [HttpGet]
        public async Task<ActionResult<CustomersListViewModel>> GetAll()
        {
            return Ok(await Mediator.Send(new GetCustomersListQuery()));
        }

        // GET api/customers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerDetailModel>> Get(string id)
        {
            return Ok(await Mediator.Send(new GetCustomerDetailQuery { Id = id }));
        }

        // POST api/customers
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public async Task<IActionResult> Create([FromBody]CreateCustomerCommand command)
        {
            await Mediator.Send(command);

            return NoContent();
        }

        // PUT api/customers/5
        [HttpPut("{id}")]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public async Task<IActionResult> Update(string id, [FromBody]UpdateCustomerCommand command)
        {
            await Mediator.Send(command);

            return NoContent();
        }

        // DELETE api/customers/5
        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public async Task<IActionResult> Delete(string id)
        {
            await Mediator.Send(new DeleteCustomerCommand { Id = id });

            return NoContent();
        }
    }
}