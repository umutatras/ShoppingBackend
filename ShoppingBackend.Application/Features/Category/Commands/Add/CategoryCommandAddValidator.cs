using FluentValidation;
using ShoppingBackend.Application.Features.Auth.Commands.UpdateUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Application.Features.Category.Commands.Add;

public sealed class CategoryCommandAddValidator : AbstractValidator<CategoryAddCommand
    >
{
    public CategoryCommandAddValidator()
    {
        RuleFor(x => x.Name)
   .NotEmpty()
   .WithMessage("Name is not null");

        RuleFor(x => x.Name)
        .NotEmpty()
        .MinimumLength(3);
    }

}