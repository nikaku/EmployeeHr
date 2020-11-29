using AutoMapper;
using EmployeeHr.BL.Dtos.Address;
using EmployeeHr.BL.Entities;

namespace EmployeeHr.BL.AutomapperProfiles
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
