using AutoMapper;
using Hr.BL.Dtos.BasePositionStaffEntity;
using Hr.BL.Entities;

namespace Hr.BL.AutomapperProfiles
{
    public class BasePositionStaffEntityProfile : Profile
    {
        public BasePositionStaffEntityProfile()
        {
            CreateMap<UpdateBasePositionStaffEntityDto, BasePositionStaffEntity>().ForMember(des => des.PositionsAndDepartments, opts => opts
                  .MapFrom(src =>
                  new PositionsAndDepartments
                  {
                      BranchId = src.BranchId,
                      DepartmentId = src.DepartmentId,
                      PositionId = src.PositinId
                  }));

            CreateMap<CreateBasePositionStaffEntityDto, BasePositionStaffEntity>();
            CreateMap<BasePositionStaffEntity, GetBasePositionStaffEntityDto>();
        }
    }
}
