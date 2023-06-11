

using FluentValidation;

namespace HRLeaveManagement.Application.DTOs.LeaveType.Validators
{
    public class CreateLeaveTypeDtoValidator : AbstractValidator<CreateLeaveTypeDto>
    {
        public CreateLeaveTypeDtoValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .WithMessage("{Propertyname} is required")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters");

            RuleFor(p => p.DefaultDays)
                .NotEmpty()
                .WithMessage("{Propertyname} is required")
                .NotNull()
                .GreaterThan(0)
                .LessThan(100);
        }

    }
}
