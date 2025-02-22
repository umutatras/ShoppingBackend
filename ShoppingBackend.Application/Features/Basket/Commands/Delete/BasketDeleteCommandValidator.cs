using FluentValidation;

namespace ShoppingBackend.Application.Features.Basket.Commands.Delete;

public class BasketDeleteCommandValidator : AbstractValidator<BasketDeleteCommand
    >
{
    public BasketDeleteCommandValidator()
    {
        RuleFor(x => x.Id)
    .NotEmpty()
    .WithMessage("Id is not null");

    }

}