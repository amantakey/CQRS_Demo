using MediatR;
using ShoppingCart.Core.Commands.Customer;
using System.Threading;
using System.Threading.Tasks;

namespace ShoppingCart.Core.Handlers.Customer
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand, int>
    {
        Task<int> IRequestHandler<CreateCustomerCommand, int>.Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
