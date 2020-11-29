using EmployeeHr.BL.Dtos.Municipality;
using System.Collections.Generic;

namespace EmployeeHr.BL.Dtos.Region
{
    public class GetRegionDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<GetMunicipalityDto> Municipalities { get; set; }
    }
}
