using AutoMapper;
using EmployeeHr.BL.Dtos.Settlement;
using EmployeeHr.BL.Entities;

namespace EmployeeHr.BL.AutomapperProfiles
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
