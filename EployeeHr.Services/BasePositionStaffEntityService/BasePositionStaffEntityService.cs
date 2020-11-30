using AutoMapper;
using Hr.BL.Dtos.BasePositionStaffEntity;
using Hr.BL.Entities;
using Hr.BL.Interaces;
using System;
using System.Collections.Generic;

namespace Hr.Services.BasePositionStaffEntityService
{
    public class BasePositionStaffEntityService : IBasePositionStaffEntityService
    {
        private IMapper _mapper;
        private IUnitOfWork _unitOfWork;

        public BasePositionStaffEntityService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public GetBasePositionStaffEntityDto Add(CreateBasePositionStaffEntityDto getBasePositionStaffEntityDto)
        {
            var basePosition = _mapper.Map<BasePositionStaffEntity>(getBasePositionStaffEntityDto);
            var basePositionInDb = _unitOfWork.BasePositionStaffEntityRepositorty.Add(basePosition);
            _unitOfWork.SaveChanges();
            return _mapper.Map<GetBasePositionStaffEntityDto>(basePositionInDb);
        }

        public void Delete(int id)
        {
            var branch = _unitOfWork.BranchRepository.Get(id);
            if (branch != null)
            {
                _unitOfWork.BranchRepository.Remove(branch);
                _unitOfWork.SaveChanges();
            }
        }

        public GetBasePositionStaffEntityDto Get(int id)
        {
            var branch = _unitOfWork.BranchRepository.Get(id);
            var branchDto = _mapper.Map<GetBasePositionStaffEntityDto>(branch);
            return branchDto;
        }

        public IEnumerable<GetBasePositionStaffEntityDto> GetAll()
        {
            var branches = _unitOfWork.BranchRepository.GetAll();
            var branchDtos = _mapper.Map<IEnumerable<GetBasePositionStaffEntityDto>>(branches);
            return branchDtos;
        }

        public GetBasePositionStaffEntityDto Update(UpdateBasePositionStaffEntityDto basePosition)
        {
            var basePositionInDb = _unitOfWork.BasePositionStaffEntityRepositorty.Get(basePosition.Id);
            if (basePositionInDb == null)
            {
                throw new Exception("Not Found");
            }

            basePositionInDb.Name = basePosition.Name;
            basePositionInDb.PositionsAndDepartmentsId = basePosition.PositionsAndDepartmentsId;


            _unitOfWork.BasePositionStaffEntityRepositorty.Update(basePositionInDb);
            _unitOfWork.SaveChanges();
            return _mapper.Map<GetBasePositionStaffEntityDto>(basePositionInDb);
        }
    }
}
