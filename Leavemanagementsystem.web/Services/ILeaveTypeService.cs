using Leavemanagementsystem.web.Models.LeaveTypes;

namespace Leavemanagementsystem.web.Services
{
    public interface ILeaveTypeService
    {
        Task<bool> CheckIfLeaveTypeNameExists(string name);
        Task<bool> CheckIfLeaveTypeNameExistsForEdit(LeaveTypeEditVM leaveTypeEdit);
        Task CreateLeaveType(LeaveTypeCreateVM model);
        Task EditLeaveType(LeaveTypeEditVM model);
        Task<List<LeaveTypeReadOnlyVM>> GetAllLEaveTyoes();
        Task<T?> GetLeaveType<T>(int id) where T : class;
        bool LeaveTypeExists(int id);
        Task RemoveLeaveType(int id);
    }
}