using AutoMapper;
using Hr.BL.Dtos.Branch;
using Hr.BL.Entities;
using Hr.BL.Interaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EployeeHr.Services.BranchService
{
    public class BranchService : IBranchService
    {
        private IMapper _mapper;
        private IUnitOfWork _unitOfWork;

        public BranchService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public GetBranchDto Add(CreateBranchDto branchDto)
        {
            var branch = _mapper.Map<Branch>(branchDto);
            var branchInDb = _unitOfWork.BranchRepository.Add(branch);
            _unitOfWork.SaveChanges();
            return _mapper.Map<GetBranchDto>(branchInDb);
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

        public GetBranchDto Get(int id)
        {
            var branch = _unitOfWork.BranchRepository.Get(id);
            var branchDto = _mapper.Map<GetBranchDto>(branch);
            return branchDto;
        }

        public IEnumerable<GetBranchDto> GetAll()
        {
            var branches = _unitOfWork.BranchRepository.GetAll();
            var branchDtos = _mapper.Map<IEnumerable<GetBranchDto>>(branches);
            return branchDtos;
        }

        public GetBranchDto Update(UpdateBranchDto branch)
        {
            var branchInDb = _unitOfWork.BranchRepository.Get(branch.Id);
            if (branchInDb == null)
            {
                throw new Exception("Not Found");
            }

            branchInDb.Email = branch.Email;
            branchInDb.ForeignName = branch.ForeignName;
            branchInDb.LegalFrom = branch.LegalFrom;
            branchInDb.LocalName = branch.LocalName;
            branchInDb.OutpatientCases = branch.OutpatientCases;
            branchInDb.PhoneNumber = branch.PhoneNumber;
            branchInDb.SendSms = branch.SendSms;
            branchInDb.StationalCases = branch.StationalCases;
            branchInDb.Status = branch.Status;
            branchInDb.AddressId = branch.AddressId;

            _unitOfWork.BranchRepository.Update(branchInDb);
            _unitOfWork.SaveChanges();
            return _mapper.Map<GetBranchDto>(branchInDb);
        }
    }
}
