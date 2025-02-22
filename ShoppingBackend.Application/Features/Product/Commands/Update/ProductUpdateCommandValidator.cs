using FluentValidation;

namespace ShoppingBackend.Application.Features.Product.Commands.Update;

public sealed class ProductUpdateCommandValidator : AbstractValidator<ProductUpdateCommand
    >
{
    public ProductUpdateCommandValidator()
    {
        RuleFor(x => x.Name)
   .NotEmpty()
   .WithMessage("Name is not null");

        RuleFor(x => x.Name)
        .NotEmpty()
        .MinimumLength(3);
    }

}
