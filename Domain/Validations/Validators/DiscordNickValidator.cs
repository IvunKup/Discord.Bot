using FluentValidation;

namespace Domain.Validations.Validators;

public class DiscordNickValidator: AbstractValidator<string>
{
    public DiscordNickValidator(string paramName)
    {
        RuleFor(d => d)
            .NotNull().WithMessage(string.Format(ErrorMasages.IsNull, paramName))
            .NotEmpty().WithMessage(string.Format(ErrorMasages.IsEmpty, paramName))
            .Matches(RegexPatterns.NickRegex);
    }
}