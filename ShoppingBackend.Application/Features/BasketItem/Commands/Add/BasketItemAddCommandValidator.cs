using FluentValidation;

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