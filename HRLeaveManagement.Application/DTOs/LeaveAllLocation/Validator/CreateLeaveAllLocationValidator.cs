

using FluentValidation;

namespace HRLeaveManagement.Application.DTOs.LeaveAllLocation.Validator
{
    public class CreateLeaveAllLocationValidator : AbstractValidator<CreateLeaveAllLocationDto>
    {
        public CreateLeaveAllLocationValidator()
        {
            RuleFor(l => l.NumberOfDays)
                .NotEmpty()
                .WithMessage("{PropertyName} is required")
                .NotNull()
                .GreaterThan(0)
                .LessThan(100);

            RuleFor(l => l.Period)
                .NotEmpty()
                .WithMessage("{PropertyName} is required")
                .NotNull()
                .GreaterThan(0)
                .LessThan(100);

            RuleFor(l => l.LeaveTypeId)
               .GreaterThan(0)
               .LessThan(100);
        }
    }
}
