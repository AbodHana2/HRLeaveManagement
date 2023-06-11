using HRLeaveManagement.Application.DTOs.LeaveAllLocation;
using MediatR;

namespace HRLeaveManagement.Application.Features.LeaveAllLocations.Requests.Queries
{
    public class GetAllLocationDetailsRequest : IRequest<LeaveAllLocationDto>
    {
        public int Id { get; set; }
    }
}
