using FluentValidation;
using ShoppingBackend.Application.Features.Category.Commands.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Application.Features.Category.Commands.Delete;

public sealed class CategoryDeleteCommadValidator : AbstractValidator<CategoryDeleteCommand
    >
{
    public CategoryDeleteCommadValidator()
    {
        RuleFor(x => x.Id)
   .NotEmpty()
   .WithMessage("Id is not null");

    }

}