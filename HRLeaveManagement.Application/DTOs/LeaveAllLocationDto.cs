

using HRLeaveManagement.Application.DTOs.Common;


namespace HRLeaveManagement.Application.DTOs
{
    public class LeaveAllLocationDto : BaseDto
    {
        public int NumberOfDays { get; set; }
        public LeaveTypeDto? LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
