using FluentValidation;

namespace ShoppingBackend.Application.Features.Basket.Commands.Add;

public sealed class BasketAddCommandValidator : AbstractValidator<BasketAddCommand
    >
{
    public BasketAddCommandValidator()
    {
        RuleFor(x => x.UserId)
   .NotEmpty()
   .WithMessage("UserId is not null");

    }

}