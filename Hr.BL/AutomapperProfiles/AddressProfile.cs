using AutoMapper;
using Hr.BL.Dtos.Address;
using Hr.BL.Entities;

namespace Hr.BL.AutomapperProfiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<CreateAddressDto, Address>();
            CreateMap<UpdateAddressDto, Address>();
            CreateMap<Address, GetAddressDto>();
        }
    }
}
