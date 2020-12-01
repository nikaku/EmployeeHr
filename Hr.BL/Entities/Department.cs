using System;
using System.Collections.Generic;

namespace Hr.BL.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Area { get; set; }
        public string Fund { get; set; }
        public int Order { get; set; }
        public DateTime CreateDate { get; set; }
        public ICollection<DepartmentsAndBranches> DepartmentsAndBranches { get; set; }
        public ICollection<PositionsAndDepartments> PositionsAndDepartments { get; set; }

    }
}
