using EmployeeHr.BL.Dtos.Address;
using EmployeeHr.BL.Enums;

namespace EmployeeHr.BL.Dtos.Branch
{
    public class GetBranchDto
    {
        public int Id { get; set; }
        public string LocalName { get; set; }
        public string ForeignName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Status Status { get; set; }
        public LegalFrom LegalFrom { get; set; }
        public string Comment { get; set; }
        public GetAddressDto Address { get; set; }
        public bool StationalCases { get; set; }
        public bool OutpatientCases { get; set; }
        public bool SendSms { get; set; }
    }
}
