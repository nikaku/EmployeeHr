using AutoMapper;
using Hr.BL.Dtos.Address;
using Hr.BL.Entities;
using Hr.BL.Interaces;
using System;
using System.Collections.Generic;

namespace EployeeHr.Services.AddressService
{
    public class AddressService : IAddressService
    {
        private IMapper _mapper;
        private IUnitOfWork _unitOfWork;

        public AddressService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public GetAddressDto Add(CreateAddressDto createAddressDto)
        {
            var address = _mapper.Map<Address>(createAddressDto);
            var addressInDb = _unitOfWork.AddressRepository.Add(address);
            _unitOfWork.SaveChanges();
            return _mapper.Map<GetAddressDto>(addressInDb);
        }

        public void Delete(int id)
        {
            var address = _unitOfWork.AddressRepository.Get(id);
            if (address != null)
            {
                _unitOfWork.AddressRepository.Remove(address);
                _unitOfWork.SaveChanges();
            }
        }

        public GetAddressDto Get(int id)
        {
            var address = _unitOfWork.AddressRepository.Get(id);
            var addressDto = _mapper.Map<GetAddressDto>(address);
            return addressDto;
        }

        public IEnumerable<GetAddressDto> GetAll()
        {
            var addresses = _unitOfWork.AddressRepository.GetAll();
            var addressDtos = _mapper.Map<IEnumerable<GetAddressDto>>(addresses);
            return addressDtos;
        }

        public GetAddressDto Update(UpdateAddressDto addressDto)
        {
            var addressInDb = _unitOfWork.AddressRepository.Get(addressDto.Id);
            if (addressInDb == null)
            {
                throw new Exception("Not Found");
            }
            addressInDb.AddressDescription = addressDto.AddressDescription;
            _unitOfWork.AddressRepository.Update(addressInDb);
            _unitOfWork.SaveChanges();
            return _mapper.Map<GetAddressDto>(addressInDb);
        }
    }
}
