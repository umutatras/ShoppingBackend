using FluentValidation;

namespace ShoppingBackend.Application.Features.ProductCategory.Commands.Add;

public class ProductCategoryAddCommandValidator : AbstractValidator<ProductCategoryAddCommand
    >
{
    public ProductCategoryAddCommandValidator()
    {
        RuleFor(x => x.ProductId)
   .NotEmpty()
   .WithMessage("ProductId is not null");

    }

}