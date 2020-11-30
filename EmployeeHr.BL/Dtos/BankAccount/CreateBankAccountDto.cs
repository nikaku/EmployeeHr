using Hr.BL.Enums;
using System;

namespace Hr.BL.Dtos.BankAccount
{
    public class CreateBankAccountDto
    {
        public string Code { get; set; }
        public string AccountNumber { get; set; }
        public AccountType Type { get; set; }
        public int BranchId { get; set; }
    }
}
