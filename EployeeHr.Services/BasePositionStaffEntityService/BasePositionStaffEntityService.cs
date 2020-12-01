using AutoMapper;
using Hr.BL.Dtos.BasePositionStaffEntity;
using Hr.BL.Entities;
using Hr.BL.Interaces;
using System;
using System.Collections.Generic;
using System.Linq;

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
            int vacancies = VacancyCount(getBasePositionStaffEntityDto.PositinId, getBasePositionStaffEntityDto.DepartmentId, getBasePositionStaffEntityDto.BranchId);

            if (vacancies == 0)
            {
                throw new Exception("Positions Limit Has Reached");
            }

            var basePosition = _mapper.Map<BasePositionStaffEntity>(getBasePositionStaffEntityDto);
            basePosition.PositionsAndDepartmentsId = _unitOfWork.PositionsAndDepartmentRepository.Find(x => x.BranchId == getBasePositionStaffEntityDto.BranchId
             && x.DepartmentId == getBasePositionStaffEntityDto.DepartmentId
             && x.PositionId == getBasePositionStaffEntityDto.PositinId).Id;

            var basePositionInDb = _unitOfWork.BasePositionStaffEntityRepositorty.Add(basePosition);

            _unitOfWork.SaveChanges();
            return _mapper.Map<GetBasePositionStaffEntityDto>(basePositionInDb);
        }         

        public void Delete(int id)
        {
            var baseEntity = _unitOfWork.BasePositionStaffEntityRepositorty.Get(id);
            if (baseEntity != null)
            {
                _unitOfWork.BasePositionStaffEntityRepositorty.Remove(baseEntity);
                _unitOfWork.SaveChanges();
            }
        }

        public GetBasePositionStaffEntityDto Get(int id)
        {
            var baseEntity = _unitOfWork.BasePositionStaffEntityRepositorty.Get(id);
            var branchDto = _mapper.Map<GetBasePositionStaffEntityDto>(baseEntity);
            return branchDto;
        }

        public IEnumerable<GetBasePositionStaffEntityDto> GetAll()
        {
            var baseEntities = _unitOfWork.BasePositionStaffEntityRepositorty.GetAll();
            var baseEntityDtos = _mapper.Map<IEnumerable<GetBasePositionStaffEntityDto>>(baseEntities);
            return baseEntityDtos;
        }

        public GetBasePositionStaffEntityDto Update(UpdateBasePositionStaffEntityDto basePosition)
        {
            var basePositionInDb = _unitOfWork.BasePositionStaffEntityRepositorty.Get(basePosition.Id);
            if (basePositionInDb == null)
            {
                throw new Exception("Not Found");
            }

            var bp = _mapper.Map<BasePositionStaffEntity>(basePosition);
            basePositionInDb.Name = basePosition.Name;
            basePositionInDb.PositionsAndDepartments = bp.PositionsAndDepartments;

            _unitOfWork.BasePositionStaffEntityRepositorty.Update(basePositionInDb);
            _unitOfWork.SaveChanges();
            return _mapper.Map<GetBasePositionStaffEntityDto>(basePositionInDb);
        }

        public int VacancyCount(int positionId, int departmentId, int branchId)
        {
            var entity = _unitOfWork.PositionsAndDepartmentRepository.Find(x => x.PositionId == positionId && x.DepartmentId == departmentId && x.BranchId == branchId);

            var maxPositions = entity.StaffNumber;
            var BasePositionStaffEntitiesId = entity.Id;

            var positionsCount = _unitOfWork.BasePositionStaffEntityRepositorty.FindAll(x => x.PositionsAndDepartmentsId == BasePositionStaffEntitiesId).Count();

            return maxPositions - positionsCount < 0 ? 0 : maxPositions - positionsCount;
        }
    }
}
