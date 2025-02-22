using FluentValidation;

namespace ShoppingBackend.Application.Features.BasketItem.Commands.Delete;

public class BasketItemDeleteCommandValidator : AbstractValidator<BasketItemDeleteCommand
    >
{
    public BasketItemDeleteCommandValidator()
    {
        RuleFor(x => x.Id)
    .NotEmpty()
    .WithMessage("Id is not null");

    }

}