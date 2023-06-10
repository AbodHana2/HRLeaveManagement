using HRLeaveManagement.Domain;

namespace HRLeaveManagement.Application.Persistence.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<LeaveRequest> GetLeaveRequestswithDetails(int id);
        Task<List<LeaveRequest>> GetLeaveRequestswithDetails();

    }
}
