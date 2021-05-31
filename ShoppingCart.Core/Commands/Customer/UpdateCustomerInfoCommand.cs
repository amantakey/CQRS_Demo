using MediatR;

namespace ShoppingCart.Core.Commands.Customer
{
    public class UpdateCustomerInfoCommand : Models.Customer, IRequest<bool>
    {

    }
}
