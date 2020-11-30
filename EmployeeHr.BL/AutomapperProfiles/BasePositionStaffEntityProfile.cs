using AutoMapper;
using Hr.BL.Dtos.BasePositionStaffEntity;
using Hr.BL.Entities;

namespace Hr.BL.AutomapperProfiles
{
    public class BasePositionStaffEntityProfile : Profile
    {
        public BasePositionStaffEntityProfile()
        {
            CreateMap<UpdateBasePositionStaffEntityDto, BasePositionStaffEntity>();
            CreateMap<CreateBasePositionStaffEntityDto, BasePositionStaffEntity>();
            CreateMap<BasePositionStaffEntity, GetBasePositionStaffEntityDto>();
        }
    }
}
