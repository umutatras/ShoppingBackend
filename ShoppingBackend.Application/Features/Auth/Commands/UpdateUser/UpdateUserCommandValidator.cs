using FluentValidation;

namespace ShoppingBackend.Application.Features.Auth.Commands.UpdateUser;

public sealed class UpdateUserCommandValidator : AbstractValidator<UpdateUserCommand
    >
{
    public UpdateUserCommandValidator()
    {
        RuleFor(x => x.Password)
   .NotEmpty()
   .WithMessage("Password is not null");

        RuleFor(x => x.Password)
        .NotEmpty()
        .MinimumLength(6);

        RuleFor(x => x.FirstName)
        .MaximumLength(50);

        RuleFor(x => x.LastName)
        .MaximumLength(50);

    }

}