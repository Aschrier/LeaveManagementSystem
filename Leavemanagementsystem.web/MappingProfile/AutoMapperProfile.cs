using AutoMapper;
using Leavemanagementsystem.web.Data;
using Leavemanagementsystem.web.Models.LeaveTypes;

namespace Leavemanagementsystem.web.MappingProfile
{
    public class AutoMapperProfile: Profile 
    {
        public AutoMapperProfile() {
            CreateMap<LeaveType, LeaveTypeReadOnlyVM>();
            CreateMap<LeaveTypeCreateVM, LeaveType>();
            CreateMap<LeaveTypeEditVM, LeaveType>().ReverseMap();
        }

    }
}
