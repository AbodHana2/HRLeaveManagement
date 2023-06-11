using HRLeaveManagement.Application.DTOs.LeaveRequest;
using MediatR;

namespace HRLeaveManagement.Application.Features.LeaveRequests.Requests.Commands
{
    public class UpdateLeaveRequestCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public LeaveRequestDto? leaveRequest { get; set; }

        public ChangeLeaveRequestApprovalDto? changeLeaveRequestApprovalDto { get; set; }
    }
}
