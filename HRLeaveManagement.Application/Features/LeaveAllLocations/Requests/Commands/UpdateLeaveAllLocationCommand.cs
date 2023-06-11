

using HRLeaveManagement.Application.DTOs.LeaveAllLocation;
using MediatR;

namespace HRLeaveManagement.Application.Features.LeaveAllLocations.Requests.Commands
{
    public class UpdateLeaveAllLocationCommand : IRequest<Unit>
    {
        public UpdateLeaveAllLocationDto? updateLeaveAllLocationDto { get; set; }
    }
}
