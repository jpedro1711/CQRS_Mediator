﻿using CQRS_Shop.Domain.Commands.Responses;
using MediatR;

namespace CQRS_Shop.Domain.Commands.Requests
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
