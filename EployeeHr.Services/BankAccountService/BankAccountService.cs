using AutoMapper;
using Hr.BL.Dtos.BankAccount;
using Hr.BL.Entities;
using Hr.BL.Interaces;
using System;
using System.Collections.Generic;

namespace Hr.Services.BankAccountService
{
    public class BankAccountService : IBankAccountService
    {
        private IMapper _mapper;
        private IUnitOfWork _unitOfWork;

        public BankAccountService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public GetBankAccountDto Add(CreateBankAccountDto bankAccountDto)
        {
            var bankAccount = _mapper.Map<BankAccount>(bankAccountDto);
            var bankAccountInDb = _unitOfWork.BankAccountRepository.Add(bankAccount);
            _unitOfWork.SaveChanges();
            return _mapper.Map<GetBankAccountDto>(bankAccountInDb);
        }

        public void Delete(int id)
        {
            var bankAccount = _unitOfWork.BankAccountRepository.Get(id);
            if (bankAccount != null)
            {
                _unitOfWork.BankAccountRepository.Remove(bankAccount);
                _unitOfWork.SaveChanges();
            }
        }

        public GetBankAccountDto Get(int id)
        {
            var bankAccount = _unitOfWork.BankAccountRepository.Get(id);
            var bankAccountDto = _mapper.Map<GetBankAccountDto>(bankAccount);
            return bankAccountDto;
        }

        public IEnumerable<GetBankAccountDto> GetAll()
        {

            var bankAccounts = _unitOfWork.BankAccountRepository.GetAll();
            var bankAccountDtos = _mapper.Map<IEnumerable<GetBankAccountDto>>(bankAccounts);
            return bankAccountDtos;
        }

        public GetBankAccountDto Update(UpdateBankAccountDto bankAcc)
        {
            var bankAccountInDb = _unitOfWork.BankAccountRepository.Get(bankAcc.Id);
            if (bankAccountInDb == null)
            {
                throw new Exception("Not Found");
            }

            bankAccountInDb.AccountNumber = bankAcc.AccountNumber;
            bankAccountInDb.BranchId = bankAcc.BranchId;
            bankAccountInDb.Code = bankAcc.Code;
            bankAccountInDb.Type = bankAcc.Type;
            bankAccountInDb.CreateDate = DateTime.Now;

            _unitOfWork.BankAccountRepository.Update(bankAccountInDb);
            _unitOfWork.SaveChanges();
            return _mapper.Map<GetBankAccountDto>(bankAccountInDb);
        }
    }
}
