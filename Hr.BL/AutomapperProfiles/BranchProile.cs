using AutoMapper;
using Hr.BL.Dtos.Branch;
using Hr.BL.Entities;

namespace Hr.BL.AutomapperProfiles
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
