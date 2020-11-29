using System.Collections.Generic;

namespace EmployeeHr.BL.Entities
{
    public class Region
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Municipality> Municipalities { get; set; }
    }
}
