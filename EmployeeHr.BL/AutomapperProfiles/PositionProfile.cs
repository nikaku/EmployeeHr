using AutoMapper;
using Hr.BL.Dtos.Position;
using Hr.BL.Entities;
using System.Linq;

namespace Hr.BL.AutomapperProfiles
{
    public class PositionProfile : Profile
    {
        public PositionProfile()
        {
            CreateMap<CreatePostionDto, Position>()
                .ForMember(des => des.PositionsAndDepartments, opts => opts
                  .MapFrom(src => src.DepartmentIds
                  .SelectMany(dId => src.BranchIds, (Did, bId) =>
                  new PositionsAndDepartments { DepartmentId = Did, BranchId = bId, StaffNumber = src.StaffNumber })));

            CreateMap<UpdatePositionDto, Position>()
                .ForMember(des => des.PositionsAndDepartments, opts => opts
                  .MapFrom(src => src.DepartmentIds
                  .SelectMany(dId => src.BranchIds, (Did, bId) =>
                  new PositionsAndDepartments { DepartmentId = Did, BranchId = bId, StaffNumber = src.StaffNumber })));

            CreateMap<Position, GetPositionDto>()
                .ForMember(des => des.Departments, opts => opts
                  .MapFrom(src => src.PositionsAndDepartments
                  .Select(x => x.Department)))
                .ForMember(des => des.Branches, opts => opts
                  .MapFrom(src => src.PositionsAndDepartments
                  .Select(x => x.Branch)));
        }
    }
}
