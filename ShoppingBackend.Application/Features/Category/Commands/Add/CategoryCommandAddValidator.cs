using FluentValidation;

namespace ShoppingBackend.Application.Features.Category.Commands.Add;

public sealed class CategoryCommandAddValidator : AbstractValidator<CategoryAddCommand
    >
{
    public CategoryCommandAddValidator()
    {
        RuleFor(x => x.Name)
   .NotEmpty()
   .WithMessage("Name is not null");

        RuleFor(x => x.Name)
        .NotEmpty()
        .MinimumLength(3);
    }

}