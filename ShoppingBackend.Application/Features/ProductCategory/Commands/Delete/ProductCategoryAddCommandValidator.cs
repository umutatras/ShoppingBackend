using FluentValidation;

namespace ShoppingBackend.Application.Features.ProductCategory.Commands.Delete;

public class ProductCategoryAddCommandValidator : AbstractValidator<ProductCategoryDeleteCommand
    >
{
    public ProductCategoryAddCommandValidator()
    {
        RuleFor(x => x.Id)
   .NotEmpty()
   .WithMessage("Id is not null");

    }

}