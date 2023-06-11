using AutoMapper;
using HRLeaveManagement.Application.DTOs.LeaveAllLocation;
using HRLeaveManagement.Application.Features.LeaveAllLocations.Requests.Queries;
using HRLeaveManagement.Application.Persistence.Contracts;
using MediatR;

namespace HRLeaveManagement.Application.Features.LeaveAllLocations.Handlers.Queries
{
    public class GetAllLocationDetailsRequestHandler : IRequestHandler<GetAllLocationDetailsRequest, LeaveAllLocationDto>
    {
        private readonly ILeaveAllLocationRepository _leaveAllLocation;
        private readonly IMapper _mapper;

        public GetAllLocationDetailsRequestHandler(ILeaveAllLocationRepository leaveAllLocation, IMapper mapper)
        {
            _leaveAllLocation = leaveAllLocation;
            _mapper = mapper;
        }

        public async Task<LeaveAllLocationDto> Handle(GetAllLocationDetailsRequest request, CancellationToken cancellationToken)
        {
            var leaveAllLocations = await _leaveAllLocation.GetLeaveAllocationwithDetails(request.Id);
            return _mapper.Map<LeaveAllLocationDto>(leaveAllLocations);
        }
    }
}
