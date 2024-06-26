using FluentValidation;

namespace Domain.Validations.Validators;

public class DateTimeValidator: AbstractValidator<DateTime>
{
    public DateTimeValidator(string paramName)
    {
        RuleFor(d => d)
            .NotEmpty().WithMessage(string.Format(ErrorMessages.IsEmpty, paramName))
            .LessThan(DateTime.Now)
            .GreaterThan(DateTime.Now.AddYears(-1200));
    }
}