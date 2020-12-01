using AutoMapper;
using Hr.BL.Dtos.Municipality;
using Hr.BL.Entities;

namespace Hr.BL.AutomapperProfiles
{
    public class MunicipalityProfile : Profile
    {
        public MunicipalityProfile()
        {
            CreateMap<CreateMunicipalityDto, Municipality>();
            CreateMap<UpdateMunicipalityDto, Municipality>();
            CreateMap<Municipality, GetMunicipalityDto>();
        }
    }
}
