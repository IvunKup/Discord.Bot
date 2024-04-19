using Domain.Entities;
using FluentValidation;

namespace Domain.Validations.Validators;

public class PhoneValidator: AbstractValidator<string>
{
    public PhoneValidator(string paramName)
    {
        RuleFor(p => p)
            .NotNull().WithMessage(string.Format(ErrorMasages.IsNull, paramName))
            .NotEmpty().WithMessage(string.Format(ErrorMasages.IsEmpty, paramName))
            .Matches(RegexPatterns.PhoneRegex).WithMessage(ErrorMasages.PhoneFormat);
    }
}