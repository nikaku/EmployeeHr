using AutoMapper;
using Hr.BL.Dtos.Position;
using Hr.BL.Entities;
using Hr.BL.Interaces;
using System;
using System.Collections.Generic;

namespace Hr.Services.PositionService
{
    public class PositionService : IPositionService
    {
        private IMapper _mapper;
        private IUnitOfWork _unitOfWork;

        public PositionService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public GetPositionDto Add(CreatePostionDto createPostionDto)
        {
            var position = _mapper.Map<Position>(createPostionDto);
            var positionInDb = _unitOfWork.PositionRepository.Add(position);
            _unitOfWork.SaveChanges();
            return _mapper.Map<GetPositionDto>(positionInDb); ;
        }

        public void Delete(int id)
        {
            var position = _unitOfWork.PositionRepository.Get(id);
            if (position != null)
            {
                _unitOfWork.PositionRepository.Remove(position);
                _unitOfWork.SaveChanges();
            }
        }

        public GetPositionDto Get(int id)
        {
            var position = _unitOfWork.PositionRepository.Get(id);
            var positionDto = _mapper.Map<GetPositionDto>(position);
            return positionDto;
        }

        public IEnumerable<GetPositionDto> GetAll()
        {
            var positions = _unitOfWork.PositionRepository.GetAll();
            var positionDtos = _mapper.Map<IEnumerable<GetPositionDto>>(positions);
            return positionDtos;
        }

        public GetPositionDto Update(UpdatePositionDto updatePositionDto)
        {
            var positionInDb = _unitOfWork.PositionRepository.Get(updatePositionDto.Id);
            if (positionInDb == null)
            {
                throw new Exception("Not Found");
            }

            var position  = _mapper.Map<Position>(updatePositionDto);
            positionInDb.Name = updatePositionDto.Name;
            positionInDb.PositionsAndDepartments = position.PositionsAndDepartments;

            _unitOfWork.PositionRepository.Update(positionInDb);
            _unitOfWork.SaveChanges();
            return _mapper.Map<GetPositionDto>(positionInDb);
        }
    }
}
