using Hr.BL.Enums;
using System;

namespace Hr.BL.Entities
{
    public class BankAccount
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string AccountNumber { get; set; }
        public AccountType Type { get; set; }
        public DateTime CreateDate { get; set; }
        public Branch Branch { get; set; }
    }
}
