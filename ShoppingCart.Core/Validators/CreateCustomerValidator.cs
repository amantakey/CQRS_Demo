using FluentValidation;
using ShoppingCart.Core.Commands.Customer;

namespace ShoppingCart.Core.Validators
{
    public class CreateCustomerValidator : AbstractValidator<CreateCustomerCommand>
    {
        public CreateCustomerValidator()
        {
            RuleFor(x => x.UserEmail)
               .NotEmpty();

        }
    }
}
