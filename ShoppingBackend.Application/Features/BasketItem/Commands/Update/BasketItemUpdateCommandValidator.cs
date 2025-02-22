using FluentValidation;
using ShoppingBackend.Application.Features.Basket.Commands.Add;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Application.Features.BasketItem.Commands.Update;

public class BasketItemUpdateCommandValidator : AbstractValidator<BasketItemUpdateCommand
    >
{
    public BasketItemUpdateCommandValidator()
    {
        RuleFor(x => x.ProductId)
   .NotEmpty()
   .WithMessage("ProductId is not null");

    }

}