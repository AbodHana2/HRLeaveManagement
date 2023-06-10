
using HRLeaveManagement.Domain;

namespace HRLeaveManagement.Application.Persistence.Contracts
{
    public interface ILeaveAllLocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task<LeaveRequest> GetLeaveAllocationwithDetails(int id);
        Task<List<LeaveRequest>> GetLeaveAllocationwithDetails();
    }
}
