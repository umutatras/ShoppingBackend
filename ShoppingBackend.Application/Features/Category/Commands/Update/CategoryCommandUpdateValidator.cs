using FluentValidation;

namespace ShoppingBackend.Application.Features.Category.Commands.Update;

public sealed class CategoryCommandUpdateValidator : AbstractValidator<CategoryUpdateCommand
    >
{
    public CategoryCommandUpdateValidator()
    {
        RuleFor(x => x.Name)
   .NotEmpty()
   .WithMessage("Name is not null");

        RuleFor(x => x.Name)
        .NotEmpty()
        .MinimumLength(3);
    }

}