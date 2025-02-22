using FluentValidation;
using ShoppingBackend.Application.Features.BasketItem.Commands.Add;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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