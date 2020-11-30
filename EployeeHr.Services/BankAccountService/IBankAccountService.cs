using Hr.BL.Dtos.BankAccount;
using System.Collections.Generic;

namespace Hr.Services.BankAccountService
{
    public interface IBankAccountService
    {
        GetBankAccountDto Add(CreateBankAccountDto bankAccountDto);
        GetBankAccountDto Get(int id);
        IEnumerable<GetBankAccountDto> GetAll();
        void Delete(int id);
        GetBankAccountDto Update(UpdateBankAccountDto bankAccountDto);
    }
}
