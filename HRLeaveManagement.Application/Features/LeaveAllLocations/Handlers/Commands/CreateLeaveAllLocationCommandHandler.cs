using AutoMapper;
using HRLeaveManagement.Application.Features.LeaveAllLocations.Requests.Commands;
using HRLeaveManagement.Application.Persistence.Contracts;
using HRLeaveManagement.Domain;
using MediatR;


namespace HRLeaveManagement.Application.Features.LeaveAllLocations.Handlers.Commands
{
    public class CreateLeaveAllLocationCommandHandler : IRequestHandler<CreateLeaveAllLocationCommand, int>
    {
        private readonly ILeaveAllLocationRepository _leaveAllLocationRepository;
        private readonly IMapper _mapper;

        public CreateLeaveAllLocationCommandHandler(ILeaveAllLocationRepository leaveAllLocationRepository, IMapper mapper)
        {
            _leaveAllLocationRepository = leaveAllLocationRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateLeaveAllLocationCommand request, CancellationToken cancellationToken)
        {
            var leaveAllloactions = _mapper.Map<LeaveAllocation>(request.leaveAllLocationDto);
            leaveAllloactions = await _leaveAllLocationRepository.Add(leaveAllloactions);
            return leaveAllloactions.Id;
        }
    }
}
