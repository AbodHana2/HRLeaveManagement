using AutoMapper;
using HRLeaveManagement.Application.DTOs.LeaveType;
using HRLeaveManagement.Application.Features.LeaveTypes.Requests.Queries;
using HRLeaveManagement.Application.Persistence.Contracts;
using MediatR;

namespace HRLeaveManagement.Application.Features.LeaveType.Handlers.Queries
{
    public class GetLeaveTypeDeatilsRequestHandler : IRequestHandler<GetLeaveTypeDeatilsRequest, LeaveTypeDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public GetLeaveTypeDeatilsRequestHandler(ILeaveTypeRepository leaveTypeRepository,  IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }

        public async Task<LeaveTypeDto> Handle(GetLeaveTypeDeatilsRequest request, CancellationToken cancellationToken)
        {
            var leaveType = await _leaveTypeRepository.GetOne(request.Id);
            return _mapper.Map<LeaveTypeDto>(leaveType);
        }
    }
}
