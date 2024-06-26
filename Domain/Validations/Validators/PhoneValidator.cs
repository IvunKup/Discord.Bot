using Domain.Entities;
using FluentValidation;

namespace Domain.Validations.Validators;

public class PhoneValidator: AbstractValidator<string>
{
    public PhoneValidator(string paramName)
    {
        RuleFor(p => p)
            .NotNull().WithMessage(string.Format(ErrorMessages.IsNull, paramName))
            .NotEmpty().WithMessage(string.Format(ErrorMessages.IsEmpty, paramName))
            .Matches(RegexPatterns.PhoneRegex).WithMessage(ErrorMessages.PhoneFormat);
    }
}