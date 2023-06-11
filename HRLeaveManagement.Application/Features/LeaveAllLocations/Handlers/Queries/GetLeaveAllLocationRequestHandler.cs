using AutoMapper;
using HRLeaveManagement.Application.DTOs.LeaveAllLocation;
using HRLeaveManagement.Application.Features.LeaveAllLocations.Requests.Queries;
using HRLeaveManagement.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLeaveManagement.Application.Features.LeaveAllLocations.Handlers.Queries
{
    public class GetLeaveAllLocationRequestHandler : IRequestHandler<GetLeaveAllLocationRequest, List<LeaveAllLocationDto>>
    {
        private readonly ILeaveAllLocationRepository _leaveAllLocation;
        private readonly IMapper _mapper;

        public GetLeaveAllLocationRequestHandler(ILeaveAllLocationRepository leaveAllLocation, IMapper mapper)
        {
            _leaveAllLocation = leaveAllLocation;
            _mapper = mapper;
        }
        public async Task<List<LeaveAllLocationDto>> Handle(GetLeaveAllLocationRequest request, CancellationToken cancellationToken)
        {
            var allLocations = await _leaveAllLocation.GetLeaveAllocationwithDetails();
            return _mapper.Map<List<LeaveAllLocationDto>>(allLocations);
        }
    }
}
