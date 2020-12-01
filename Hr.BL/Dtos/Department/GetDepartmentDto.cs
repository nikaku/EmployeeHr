using Hr.BL.Dtos.Branch;
using System;
using System.Collections.Generic;

namespace Hr.BL.Dtos.Department
{
    public class GetDepartmentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Area { get; set; }
        public string Fund { get; set; }
        public int Order { get; set; }
        public DateTime CreateDate { get; set; }
        public List<GetBranchDto> Branches { get; set; }
    }
}
