using EmployeeHr.BL.Dtos.Settlement;
using System.Collections.Generic;

namespace EmployeeHr.BL.Dtos.Municipality
{
    public class GetMunicipalityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<GetSettlementDto> Settlements { get; set; }
    }
}
