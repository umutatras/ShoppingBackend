using FluentValidation;
using ShoppingBackend.Application.Features.Basket.Commands.Add;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Application.Features.BasketItem.Commands.Add;

public class BasketItemAddCommandValidator : AbstractValidator<BasketItemAddCommand
    >
{
    public BasketItemAddCommandValidator()
    {
        RuleFor(x => x.ProductId)
   .NotEmpty()
   .WithMessage("ProductId is not null");

    }

}