using FluentValidation;

namespace Domain.Validations.Validators;

public class FullNameValidator: AbstractValidator<string>
{
    public FullNameValidator(string paramName)
    {
        RuleFor(n => n)
            .NotNull().WithMessage(string.Format(ErrorMasages.IsNull, paramName))
            .NotEmpty().WithMessage(string.Format(ErrorMasages.IsEmpty, paramName))
            .Matches(RegexPatterns.NameRegex).WithMessage(ErrorMasages.NameGramer);
    }
}