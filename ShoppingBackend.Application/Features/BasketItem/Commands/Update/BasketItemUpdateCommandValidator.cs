using FluentValidation;

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