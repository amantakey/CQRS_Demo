using MediatR;
using ShoppingCart.Core.Commands.Order;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ShoppingCart.Core.Handlers.Order
{
    public class UpdateOrderInfoHandler : IRequestHandler<UpdateOrderInfoCommand, bool>
    {
        public Task<bool> Handle(UpdateOrderInfoCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
