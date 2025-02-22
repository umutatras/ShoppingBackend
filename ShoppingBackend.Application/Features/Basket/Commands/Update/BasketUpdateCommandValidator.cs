using FluentValidation;
using ShoppingBackend.Application.Features.Category.Commands.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Application.Features.Basket.Commands.Update;

public class BasketUpdateCommandValidator : AbstractValidator<BasketUpdateCommand
    >
{
    public BasketUpdateCommandValidator()
    {
        RuleFor(x => x.UserId)
   .NotEmpty()
   .WithMessage("UserId is not null");
    }

}