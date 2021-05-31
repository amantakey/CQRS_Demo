using MediatR;

namespace ShoppingCart.Core.Commands.Order
{
    public class CreateOrderCommand : Models.Order,IRequest<bool>
    {
    }
}
