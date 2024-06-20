using CQRS_Shop.Domain.Commands.Requests;
using CQRS_Shop.Domain.Commands.Responses;
using CQRS_Shop.Domain.Handlers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Shop.Controllers
{
    [ApiController]
    [Route("v1/customers")]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        public Task<CreateCustomerResponse> Create
            (
            [FromBody] CreateCustomerRequest command,
            [FromServices] IMediator mediator
            )
        {
            return mediator.Send(command);
        }
    }
}
