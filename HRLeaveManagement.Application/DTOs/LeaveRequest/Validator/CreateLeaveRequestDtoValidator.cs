

using FluentValidation;

namespace HRLeaveManagement.Application.DTOs.LeaveRequest.Validator
{
    public class CreateLeaveRequestDtoValidator : AbstractValidator<CreateLeaveRequestDto>
    {
        public CreateLeaveRequestDtoValidator()
        {
            RuleFor(l => l.StartDate)
                .LessThan(l => l.EndDate).WithMessage("{PropertyName} must be before {ComparisonValue}");

            RuleFor(l => l.EndDate)
                .GreaterThan(l => l.StartDate).WithMessage("{PropertyName} must be after {ComparisonValue}");
        }
    }
}
