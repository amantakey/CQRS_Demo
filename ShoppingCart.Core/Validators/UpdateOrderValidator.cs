using FluentValidation;
using ShoppingCart.Core.Commands.Order;

namespace ShoppingCart.Core.Validators
{
    public class UpdateOrderValidator : AbstractValidator<UpdateOrderInfoCommand>
    {
        public UpdateOrderValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty();

            RuleFor(x => x.Items)
                .NotNull();
        }
    }
}
