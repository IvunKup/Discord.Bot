using FluentValidation;

namespace Domain.Validations.Validators;

public class FullNameValidator: AbstractValidator<string>
{
    public FullNameValidator(string paramName)
    {
        RuleFor(n => n)
            .NotNull().WithMessage(string.Format(ErrorMessages.IsNull, paramName))
            .NotEmpty().WithMessage(string.Format(ErrorMessages.IsEmpty, paramName))
            .Matches(RegexPatterns.NameRegex).WithMessage(ErrorMessages.NameGramer);
    }
}