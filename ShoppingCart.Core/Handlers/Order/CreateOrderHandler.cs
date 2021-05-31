using MediatR;
using ShoppingCart.Core.Commands.Order;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ShoppingCart.Core.Handlers.Order
{
    public class CreateOrderHandler : IRequestHandler<CreateOrderCommand, bool>
    {
        public Task<bool> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
