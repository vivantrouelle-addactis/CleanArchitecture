using FluentValidation;

namespace CleanArchitecture.Core.Application.Features.UserFeatures.CreateUser;

public sealed class CreateUserValidator : AbstractValidator<CreateUserRequest>
{
    public CreateUserValidator()
    {
        RuleFor(x => x.Email).NotEmpty().MaximumLength(50).EmailAddress();
        RuleFor(x => x.firstName).NotEmpty().MinimumLength(3).MaximumLength(50);
        RuleFor(x => x.lastName).NotEmpty().MinimumLength(3).MaximumLength(50);
    }
}
