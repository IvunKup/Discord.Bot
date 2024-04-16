using FluentValidation;

namespace Domain.Validations.Validators;

public class DiscordNickValidator: AbstractValidator<string>
{
    public DiscordNickValidator(string paramName)
    {
        RuleFor(d => d)
            .NotNull()
            .NotEmpty()
            .Matches(RegexPatterns.NickRegex);
    }
}