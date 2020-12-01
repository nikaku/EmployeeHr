using AutoMapper;
using Hr.BL.Dtos.Region;
using Hr.BL.Entities;
using Hr.BL.Interaces;
using System;
using System.Collections.Generic;

namespace EployeeHr.Services.RegionService
{
    public class RegionService : IRegionService
    {
        private IMapper _mapper;
        private IUnitOfWork _unitOfWork;

        public RegionService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public GetRegionDto Add(CreateRegionDto regionDto)
        {
            var region = _mapper.Map<Region>(regionDto);
            var regionInDb = _unitOfWork.RegionRepository.Add(region);
            _unitOfWork.SaveChanges();
            return _mapper.Map<GetRegionDto>(regionInDb); ;
        }

        public void Delete(int id)
        {
            var region = _unitOfWork.RegionRepository.Get(id);
            if (region != null)
            {
                _unitOfWork.RegionRepository.Remove(region);
                _unitOfWork.SaveChanges();
            }
        }

        public GetRegionDto Get(int id)
        {
            var region = _unitOfWork.RegionRepository.Get(id);
            var regiondto = _mapper.Map<GetRegionDto>(region);
            return regiondto;
        }

        public IEnumerable<GetRegionDto> GetAll()
        {
            var regions = _unitOfWork.RegionRepository.GetAll();
            var regionsdto = _mapper.Map<IEnumerable<GetRegionDto>>(regions);
            return regionsdto;
        }

        public GetRegionDto Update(UpdateRegionDto region)
        {
            var regionInDb = _unitOfWork.RegionRepository.Get(region.Id);
            if (regionInDb == null)
            {
                throw new Exception("Not Found");
            }
            regionInDb.Name = region.Name;
            _unitOfWork.RegionRepository.Update(regionInDb);
            _unitOfWork.SaveChanges();
            return _mapper.Map<GetRegionDto>(regionInDb);
        }
    }
}
