using MediatR;
using ShoppingCart.Core.Queries.Order;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Models = ShoppingCart.Core.Models;

namespace ShoppingCart.Core.Handlers.Order
{
    public class GetAllOrdersQueryHandler : IRequestHandler<GetAllOrdersQuery, List<Models.Order>>
    {
        public Task<List<Models.Order>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new List<Models.Order>());
        }
    }
}
