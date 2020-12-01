using System.Collections.Generic;

namespace Hr.BL.Dtos.Department
{
    public class UpdateDepartmentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Area { get; set; }
        public string Fund { get; set; }
        public int Order { get; set; }
        public List<int> BranchIds { get; set; }
    }
}
