using AutoMapper;
using Leavemanagementsystem.web.Data;
using Leavemanagementsystem.web.Models.LeaveTypes;
using Microsoft.EntityFrameworkCore;

namespace Leavemanagementsystem.web.Services
{
    public class LeaveTypeService(ApplicationDbContext _context, IMapper _mapper) : ILeaveTypeService
    {
        

       
        public async Task<List<LeaveTypeReadOnlyVM>> GetAllLEaveTyoes()
        {
            var data = await _context.LeaveTypes.ToListAsync();


            var viewData = _mapper.Map<List<LeaveTypeReadOnlyVM>>(data);
            return viewData;
        }
        public async Task<T?> GetLeaveType<T>(int id) where T : class
        {
            var data = await _context.LeaveTypes.FirstOrDefaultAsync(x => x.Id == id);
            if (data == null)
            {
                return null;
            }
            var viewData = _mapper.Map<T>(data);
            return viewData;
        }

        public async Task RemoveLeaveType(int id)
        {
            var data = await _context.LeaveTypes.FirstOrDefaultAsync(x => x.Id == id);
            if (data != null)
            {
                _context.Remove(data);
                await _context.SaveChangesAsync();
            }
        }


        public async Task EditLeaveType(LeaveTypeEditVM model)
        {
            var leaveType = _mapper.Map<LeaveType>(model);
            _context.Update(leaveType);
            await _context.SaveChangesAsync();
        }


        public async Task CreateLeaveType(LeaveTypeCreateVM model)
        {
            var leaveType = _mapper.Map<LeaveType>(model);
            _context.Add(leaveType);
            await _context.SaveChangesAsync();
        }
        public async Task<bool> CheckIfLeaveTypeNameExists(string name)
        {
            var lowerCaseName = name.ToLower();
            return await _context.LeaveTypes.AnyAsync(q => q.Name.ToLower().Equals(lowerCaseName));
        }
        public async Task<bool> CheckIfLeaveTypeNameExistsForEdit(LeaveTypeEditVM leaveTypeEdit)
        {
            var lowerCaseName = leaveTypeEdit.Name.ToLower();
            return await _context.LeaveTypes.AnyAsync(q => q.Name.ToLower().Equals(lowerCaseName)
            && q.Id != leaveTypeEdit.Id);
        }
        public bool LeaveTypeExists(int id)
        {
            return _context.LeaveTypes.Any(e => e.Id == id);
        }
    }
}
