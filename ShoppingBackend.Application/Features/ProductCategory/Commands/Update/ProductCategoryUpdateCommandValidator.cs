using FluentValidation;

namespace ShoppingBackend.Application.Features.ProductCategory.Commands.Update;

public class ProductCategoryUpdateCommandValidator : AbstractValidator<ProductCategoryUpdateCommand
    >
{
    public ProductCategoryUpdateCommandValidator()
    {
        RuleFor(x => x.ProductId)
   .NotEmpty()
   .WithMessage("ProductId is not null");

    }

}