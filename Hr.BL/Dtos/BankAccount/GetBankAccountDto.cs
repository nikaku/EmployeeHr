using Hr.BL.Dtos.Branch;
using Hr.BL.Enums;
using System;

namespace Hr.BL.Dtos.BankAccount
{
    public class GetBankAccountDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string AccountNumber { get; set; }
        public AccountType Type { get; set; }
        public DateTime CreateDate { get; set; }
        public GetBranchDto Branch { get; set; }
    }
}
