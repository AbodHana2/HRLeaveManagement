using AutoMapper;
using HRLeaveManagement.Application.DTOs.LeaveAllLocation;
using HRLeaveManagement.Application.DTOs.LeaveRequest;
using HRLeaveManagement.Application.DTOs.LeaveType;
using HRLeaveManagement.Domain;

namespace HRLeaveManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveRequest , LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest , LeaveRequestListDto>().ReverseMap();
            CreateMap<LeaveAllocation , LeaveAllLocationDto>().ReverseMap();
            CreateMap<LeaveType , LeaveTypeDto>().ReverseMap();
        }
    }
}
