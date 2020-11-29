using AutoMapper;
using EmployeeHr.BL.Dtos.Branch;
using EmployeeHr.BL.Entities;

namespace EmployeeHr.BL.AutomapperProfiles
{
    public class BranchProile : Profile
    {
        public BranchProile()
        {
            CreateMap<CreateBranchDto, Branch>();
            CreateMap<UpdateBranchDto, Branch>();
            CreateMap<Branch, GetBranchDto>();
        }
    }
}
