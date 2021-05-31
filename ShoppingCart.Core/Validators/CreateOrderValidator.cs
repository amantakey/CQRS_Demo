using FluentValidation;
using ShoppingCart.Core.Commands.Order;

namespace ShoppingCart.Core.Validators
{
    public class CreateOrderValidator : AbstractValidator<CreateOrderCommand>
    {
        public CreateOrderValidator()
        {
            RuleFor(x => x.Items)
                .NotNull();
        }
    }
}
