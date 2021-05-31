using MediatR;
using ShoppingCart.Core.Queries.Customer;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ShoppingCart.Core.Handlers.Customer
{
    public class GetAllCustomersQueryHandler : IRequestHandler<GetAllCustomersQuery, List<Models.Customer>>
    {
        public Task<List<Models.Customer>> Handle(GetAllCustomersQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new List<Models.Customer>());
        }
    }
}
