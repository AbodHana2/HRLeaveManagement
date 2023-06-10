using HRLeaveManagement.Application.DTOs;
using MediatR;

namespace HRLeaveManagement.Application.Features.LeaveAllLocations.Requests.Queries
{
    public class GetLeaveAllLocationRequest : IRequest<List<LeaveAllLocationDto>>
    {
    }
}
