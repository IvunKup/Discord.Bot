using Domain.Entities;
using FluentValidation;

namespace Domain.Validations.Validators;

public class PersonModelValidator : AbstractValidator<Person>
{
    public PersonModelValidator()
    {
        RuleFor(p => p.PhoneNumber)
            .NotNull()
            .NotEmpty()
            .Matches(RegexPatterns.PhoneRegex)
            .WithMessage("Неправильный формат телефона");

        RuleFor(n => n.DiscordNick)
            .Matches(RegexPatterns.NickRegex)
            .WithMessage("Неправильный формат псевдонима");
    }
}