using AutoMapper;
using EmployeeHr.BL.Dtos.Settlement;
using EmployeeHr.BL.Entities;
using EmployeeHr.BL.Interaces;
using System;
using System.Collections.Generic;

namespace EployeeHr.Services.SettlementService
{
    public class SettlementService : ISettlementService
    {
        private IMapper _mapper;
        private IUnitOfWork _unitOfWork;

        public SettlementService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        } 

        public GetSettlementDto Add(CreateSettlementDto settlementDto)
        {
            var settlement = _mapper.Map<Settlement>(settlementDto);
            var settlementInDb = _unitOfWork.SettlementRepository.Add(settlement);
            _unitOfWork.SaveChanges();
            return _mapper.Map<GetSettlementDto>(settlementInDb);
        }

        public void Delete(int id)
        {
            var settlement = _unitOfWork.SettlementRepository.Get(id);
            if (settlement != null)
            {
                _unitOfWork.SettlementRepository.Remove(settlement);
                _unitOfWork.SaveChanges();
            }
        }

        public GetSettlementDto Get(int id)
        {
            var settlement = _unitOfWork.SettlementRepository.Get(id);
            var settlementDto = _mapper.Map<GetSettlementDto>(settlement);
            return settlementDto;
        }

        public IEnumerable<GetSettlementDto> GetAll()
        {
            var settlements = _unitOfWork.SettlementRepository.GetAll();
            var settlementDtos = _mapper.Map<IEnumerable<GetSettlementDto>>(settlements);
            return settlementDtos;
        }

        public GetSettlementDto Update(UpdateSettlementDto settlement)
        {
            var settlementInDb = _unitOfWork.SettlementRepository.Get(settlement.Id);
            if (settlementInDb == null)
            {
                throw new Exception("Not Found");
            }
            settlementInDb.Name = settlement.Name;
            _unitOfWork.SettlementRepository.Update(settlementInDb);
            _unitOfWork.SaveChanges();
            return _mapper.Map<GetSettlementDto>(settlementInDb); ;
        }
    }
}
