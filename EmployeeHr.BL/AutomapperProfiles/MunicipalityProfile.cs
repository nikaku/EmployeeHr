using AutoMapper;
using EmployeeHr.BL.Dtos.Municipality;
using EmployeeHr.BL.Entities;

namespace EmployeeHr.BL.AutomapperProfiles
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
