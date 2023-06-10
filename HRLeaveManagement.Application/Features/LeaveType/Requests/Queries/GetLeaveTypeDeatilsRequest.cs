using HRLeaveManagement.Application.DTOs;
using MediatR;

namespace HRLeaveManagement.Application.Features.LeaveType.Requests.Queries
{
    public class GetLeaveTypeDeatilsRequest : IRequest<LeaveTypeDto>
    {
        public int Id { get; set; }
    }
}
