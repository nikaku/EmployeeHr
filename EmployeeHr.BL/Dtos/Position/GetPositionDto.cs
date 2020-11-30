using Hr.BL.Dtos.Branch;
using Hr.BL.Dtos.Department;
using System.Collections.Generic;

namespace Hr.BL.Dtos.Position
{
    public class GetPositionDto
    {
        public int Id { get; set; }
        public int StaffNumber { get; set; }
        public string Name { get; set; }
        public List<GetDepartmentDto> Departments { get; set; }
        public List<GetBranchDto> Branches { get; set; }
    }
}
