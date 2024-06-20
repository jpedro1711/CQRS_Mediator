using CQRS_Shop.Domain.Commands.Requests;
using CQRS_Shop.Domain.Commands.Responses;
using MediatR;

namespace CQRS_Shop.Domain.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {

        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            // Verifica se o cliente já está cadastrado ...

            // Insere o cliente

            var result =  new CreateCustomerResponse { Id = new Guid(), Name = "João", Email = "joao@email.com", Date = DateTime.Now };
        
            return Task.FromResult(result);
        }
    }
}
