using EmployeeHr.BL.Dtos.Settlement;
using EmployeeHr.BL.Entities;
using System.Collections.Generic;

namespace EployeeHr.Services.SettlementService
{
    public interface ISettlementService
    {
        GetSettlementDto Add(CreateSettlementDto settlementDto);
        GetSettlementDto Get(int id);
        IEnumerable<GetSettlementDto> GetAll();
        void Delete(int id);
        GetSettlementDto Update(UpdateSettlementDto settlement);
    }
}
