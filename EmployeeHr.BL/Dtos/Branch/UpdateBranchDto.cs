using Hr.BL.Enums;

namespace Hr.BL.Dtos.Branch
{
    public class UpdateBranchDto
    {
        public int Id { get; set; }
        public string LocalName { get; set; }
        public string ForeignName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Status Status { get; set; }
        public LegalFrom LegalFrom { get; set; }
        public string Comment { get; set; }
        public int AddressId { get; set; }
        public bool StationalCases { get; set; }
        public bool OutpatientCases { get; set; }
        public bool SendSms { get; set; }
    }
}
