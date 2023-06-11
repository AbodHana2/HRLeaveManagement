using HRLeaveManagement.Application.DTOs.LeaveAllLocation;
using MediatR;

namespace HRLeaveManagement.Application.Features.LeaveAllLocations.Requests.Queries
{
    public class GetLeaveAllLocationRequest : IRequest<List<LeaveAllLocationDto>>
    {
    }
}
