using FluentValidation;

namespace ShoppingBackend.Application.Features.Category.Commands.Delete;

public sealed class CategoryDeleteCommadValidator : AbstractValidator<CategoryDeleteCommand
    >
{
    public CategoryDeleteCommadValidator()
    {
        RuleFor(x => x.Id)
   .NotEmpty()
   .WithMessage("Id is not null");

    }

}