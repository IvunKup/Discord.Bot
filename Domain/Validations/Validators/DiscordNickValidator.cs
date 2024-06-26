using FluentValidation;

namespace Domain.Validations.Validators;

public class DiscordNickValidator: AbstractValidator<string>
{
    public DiscordNickValidator(string paramName)
    {
        RuleFor(d => d)
            .NotNull().WithMessage(string.Format(ErrorMessages.IsNull, paramName))
            .NotEmpty().WithMessage(string.Format(ErrorMessages.IsEmpty, paramName))
            .Matches(RegexPatterns.NickRegex);
    }
}