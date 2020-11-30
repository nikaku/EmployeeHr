using AutoMapper;
using Hr.BL.Dtos.Department;
using Hr.BL.Entities;
using System.Linq;

namespace Hr.BL.AutomapperProfiles
{
    class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            CreateMap<Department, GetDepartmentDto>()
                .ForMember(des => des.Branches, opts => opts
                .MapFrom(src => src.DepartmentsAndBranches
                .Select(x=> x.Branch)));

            CreateMap<UpdateDepartmentDto, Department>()
                .ForMember(des => des.DepartmentsAndBranches, opts => opts
                  .MapFrom(src => src.BranchIds
                  .Select(id => new DepartmentsAndBranches { BranchId = id })));

            CreateMap<CreateDepartmentDto, Department>()
                .ForMember(des => des.DepartmentsAndBranches, opts => opts
                  .MapFrom(src => src.BranchIds
                  .Select(id => new DepartmentsAndBranches { BranchId = id })));

        }
    }
}
