using FluentValidation;

namespace Domain.Validations.Validators;

public class FullNameValidator: AbstractValidator<string>
{
    public FullNameValidator(string paramName)
    {
        RuleFor(n => n)
            .NotNull()
            .NotEmpty()
            .Matches(RegexPatterns.NameRegex);
    }
}