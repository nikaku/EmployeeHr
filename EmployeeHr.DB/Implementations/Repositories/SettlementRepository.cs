using EmployeeHr.BL.Entities;
using EmployeeHr.BL.Interaces.Repositories;

namespace EmployeeHr.DB.Implementations.Repositories
{
    public class SettlementRepository : Repository<Settlement>, ISettlementRepository
    {
        public SettlementRepository(DataContext context) : base(context)
        {

        }

        public DataContext SettlementContext => Context as DataContext;
    }
}
