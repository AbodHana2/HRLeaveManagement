using HRLeaveManagement.Application.DTOs.LeaveAllLocation;
using MediatR;

namespace HRLeaveManagement.Application.Features.LeaveAllLocations.Requests.Commands
{
    public class CreateLeaveAllLocationCommand : IRequest<int>
    {
        public CreateLeaveAllLocationDto? leaveAllLocationDto { get; set; }
    }
}
