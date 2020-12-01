using Hr.BL.Enums;
using System.Collections.Generic;

namespace Hr.BL.Entities
{
    public class Branch
    {
        public int Id { get; set; }
        public string LocalName { get; set; }
        public string ForeignName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Status Status { get; set; }
        public LegalFrom LegalFrom { get; set; }
        public string Comment { get; set; }
        public Address Address { get; set; }
        public int AddressId { get; set; }
        public bool StationalCases { get; set; }
        public bool OutpatientCases { get; set; }
        public bool SendSms { get; set; }
        public ICollection<DepartmentsAndBranches> DepartmentsAndBranches { get; set; }
    }
}
