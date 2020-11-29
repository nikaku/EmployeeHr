using AutoMapper;
using EmployeeHr.BL.Dtos.Region;
using EmployeeHr.BL.Entities;

namespace EmployeeHr.BL.AutomapperProfiles
{
    public class RegionProfile : Profile
    {
        public RegionProfile()
        {
            CreateMap<CreateRegionDto, Region>();
            CreateMap<Region, GetRegionDto>();
            CreateMap<UpdateRegionDto, Region>();
        }
    }
}
