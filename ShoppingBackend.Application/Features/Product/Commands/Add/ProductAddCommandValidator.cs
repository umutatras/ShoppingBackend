using FluentValidation;
using ShoppingBackend.Application.Features.Category.Commands.Add;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Application.Features.Product.Commands.Add;

public sealed class ProductAddCommandValidator : AbstractValidator<ProductAddCommand
    >
{
    public ProductAddCommandValidator()
    {
        RuleFor(x => x.Name)
   .NotEmpty()
   .WithMessage("Name is not null");

        RuleFor(x => x.Name)
        .NotEmpty()
        .MinimumLength(3);
    }

}