

using AutoMapper;
using HRLeaveManagement.Application.Features.LeaveAllLocations.Requests.Commands;
using HRLeaveManagement.Application.Persistence.Contracts;
using MediatR;

namespace HRLeaveManagement.Application.Features.LeaveAllLocations.Handlers.Commands
{
    public class UpdateLeaveAllLocationCommandHandler : IRequestHandler<UpdateLeaveAllLocationCommand, Unit>
    {
        private readonly ILeaveAllLocationRepository _leaveAllLocationRepository;
        private readonly IMapper _mapper;

        public UpdateLeaveAllLocationCommandHandler(ILeaveAllLocationRepository leaveAllLocationRepository, IMapper mapper)
        {
            _leaveAllLocationRepository = leaveAllLocationRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateLeaveAllLocationCommand request, CancellationToken cancellationToken)
        {
            var leaveallLocations = await _leaveAllLocationRepository.GetOne(request.updateLeaveAllLocationDto.Id);
            _mapper.Map(request.updateLeaveAllLocationDto, leaveallLocations);

            await _leaveAllLocationRepository.Update(leaveallLocations);

            return Unit.Value;
        }
    }
}
