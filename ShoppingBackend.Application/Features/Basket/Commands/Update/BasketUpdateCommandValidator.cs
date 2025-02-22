using FluentValidation;

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