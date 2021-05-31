using MediatR;

namespace ShoppingCart.Core.Commands.Order
{
    public class UpdateOrderInfoCommand : Models.Order,IRequest<bool>
    {
    }
}
