using AutoMapper;
using Hr.BL.Dtos.Municipality;
using Hr.BL.Entities;
using Hr.BL.Interaces;
using System;
using System.Collections.Generic;

namespace EployeeHr.Services.MunicipalityServie
{
    public class MunicipalityService : IMunicipalityService
    {
        private IMapper _mapper;
        private IUnitOfWork _unitOfWork;

        public MunicipalityService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public GetMunicipalityDto Add(CreateMunicipalityDto municipalityDto)
        {
            var municipality = _mapper.Map<Municipality>(municipalityDto);
            var municipalityInDb = _unitOfWork.MunicipalityRepository.Add(municipality);
            _unitOfWork.SaveChanges();
            return _mapper.Map<GetMunicipalityDto>(municipalityInDb);
        }

        public void Delete(int id)
        {
            var municipality = _unitOfWork.MunicipalityRepository.Get(id);
            if (municipality != null)
            {
                _unitOfWork.MunicipalityRepository.Remove(municipality);
                _unitOfWork.SaveChanges();
            }
        }

        public GetMunicipalityDto Get(int id)
        {
            var municipality = _unitOfWork.MunicipalityRepository.Get(id);
            var municipalityDto = _mapper.Map<GetMunicipalityDto>(municipality);
            return municipalityDto;
        }

        public IEnumerable<GetMunicipalityDto> GetAll()
        {
            var municipalities = _unitOfWork.MunicipalityRepository.GetAll();
            var municipalitDtos = _mapper.Map<IEnumerable<GetMunicipalityDto>>(municipalities);
            return municipalitDtos;
        }

        public GetMunicipalityDto Update(UpdateMunicipalityDto municipalityDto)
        {
            var municipalityInDb = _unitOfWork.MunicipalityRepository.Get(municipalityDto.Id);
            if (municipalityInDb == null)
            {
                throw new Exception("Not Found");
            }
            municipalityInDb.Name = municipalityDto.Name;

            _unitOfWork.MunicipalityRepository.Update(municipalityInDb);
            _unitOfWork.SaveChanges();
            return _mapper.Map<GetMunicipalityDto>(municipalityInDb);
        }
    }
}
