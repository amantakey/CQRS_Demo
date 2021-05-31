using MediatR;
using ShoppingCart.Core.Commands.Customer;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ShoppingCart.Core.Handlers.Customer
{
    public class UpdateCustomerInfoHandler : IRequestHandler<UpdateCustomerInfoCommand, bool>
    {
        public Task<bool> Handle(UpdateCustomerInfoCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
