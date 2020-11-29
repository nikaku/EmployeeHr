using AutoMapper;
using Hr.BL.Dtos.Settlement;
using Hr.BL.Entities;

namespace Hr.BL.AutomapperProfiles
{
    public class SettlementProfile : Profile
    {
        public SettlementProfile()
        {
            CreateMap<CreateSettlementDto, Settlement>();
            CreateMap<UpdateSettlementDto, Settlement>();
            CreateMap<Settlement, GetSettlementDto>();
        }
    }
}
