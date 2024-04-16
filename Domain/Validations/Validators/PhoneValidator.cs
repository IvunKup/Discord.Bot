﻿using Domain.Entities;
using FluentValidation;

namespace Domain.Validations.Validators;

public class PhoneValidator: AbstractValidator<string>
{
    public PhoneValidator(string paramName)
    {
        RuleFor(p => p)
            .NotNull()
            .NotEmpty()
            .Matches(RegexPatterns.PhoneRegex);
    }
}