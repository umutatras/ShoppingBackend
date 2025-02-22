using FluentValidation;

namespace ShoppingBackend.Application.Features.Product.Commands.Delete;

public sealed class ProductDeleteCommandValidator : AbstractValidator<ProductDeleteCommand
    >
{
    public ProductDeleteCommandValidator()
    {
        RuleFor(x => x.Id)
   .NotEmpty()
   .WithMessage("Id is not null");

    }

}