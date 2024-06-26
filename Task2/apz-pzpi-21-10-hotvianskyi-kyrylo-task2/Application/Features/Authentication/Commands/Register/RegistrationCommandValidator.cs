﻿using FluentValidation;

namespace Application.Features.Authentication.Commands.Register;

public class RegistrationCommandValidator : AbstractValidator<RegistrationCommand>
{
    public RegistrationCommandValidator()
    {
        RuleFor(m => m.FirstName)
            .NotEmpty().WithMessage("{PropertyName} can't be empty")
            .MaximumLength(64).WithMessage("{PropertyName} must be fewer than {ComparisonValue} characters");
        
        RuleFor(m => m.LastName)
            .NotEmpty().WithMessage("{PropertyName} can't be empty")
            .MaximumLength(64).WithMessage("{PropertyName} must be fewer than {ComparisonValue} characters");

        RuleFor(m => m.Email)
            .EmailAddress().WithMessage("Email is not valid");
        
        RuleFor(p => p.Password)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .MinimumLength(6).WithMessage("{PropertyName} must be at least {ComparisonValue} characters.")
            .MaximumLength(50).WithMessage("{PropertyName} must not exceed {ComparisonValue} characters.");

        RuleFor(p => p.Sex)
            .Must(MustBeValid).WithMessage("{PropertyName} can only have \"male\" or \"female\" values.");
    }

    private bool MustBeValid(string sex)
    {
        return sex is "male" or "female";
    }
}