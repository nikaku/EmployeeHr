using Hr.BL.Entities;
using System.Collections.Generic;

namespace Hr.BL.Dtos.Department
{
    public class CreateDepartmentDto
    {
        public string Name { get; set; }
        public int Area { get; set; }
        public string Fund { get; set; }
        public int Order { get; set; }
        public List<int> BranchIds{ get; set; } 
        
    }
}
