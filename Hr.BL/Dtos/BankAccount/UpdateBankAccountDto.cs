using Hr.BL.Enums;

namespace Hr.BL.Dtos.BankAccount
{
    public class UpdateBankAccountDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string AccountNumber { get; set; }
        public AccountType Type { get; set; }
        public int BranchId { get; set; }
    }
}
