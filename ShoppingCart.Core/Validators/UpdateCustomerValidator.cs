using FluentValidation;
using ShoppingCart.Core.Commands.Customer;

namespace ShoppingCart.Core.Validators
{
    class UpdateCustomerValidator : AbstractValidator<UpdateCustomerInfoCommand>
    {
        public UpdateCustomerValidator()
        {
            RuleFor(x => x.Id)
               .NotEmpty();
        }
    }
}
