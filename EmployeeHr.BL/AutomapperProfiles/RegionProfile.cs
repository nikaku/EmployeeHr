using AutoMapper;
using Hr.BL.Dtos.Region;
using Hr.BL.Entities;

namespace Hr.BL.AutomapperProfiles
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
