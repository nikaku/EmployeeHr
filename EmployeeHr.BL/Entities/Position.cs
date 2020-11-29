using System.Collections;
using System.Collections.Generic;

namespace EmployeeHr.BL.Entities
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<PositionsAndDepartments> PositionsAndDepartments { get; set; }
    }
}
