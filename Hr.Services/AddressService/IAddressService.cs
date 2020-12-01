using Hr.BL.Dtos.Address;
using System.Collections.Generic;

namespace EployeeHr.Services.AddressService
{
    public interface IAddressService
    {
        GetAddressDto Add(CreateAddressDto createAddressDto);
        GetAddressDto Get(int id);
        IEnumerable<GetAddressDto> GetAll();
        void Delete(int id);
        GetAddressDto Update(UpdateAddressDto updateAddressDto);
    }
}
