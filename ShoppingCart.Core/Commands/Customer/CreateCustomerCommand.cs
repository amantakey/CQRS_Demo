using MediatR;

namespace ShoppingCart.Core.Commands.Customer
{
    public class CreateCustomerCommand : Models.Customer, IRequest<int>
    {
    }
}
