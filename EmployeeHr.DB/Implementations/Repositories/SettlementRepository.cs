using Hr.BL.Entities;
using Hr.BL.Interaces.Repositories;

namespace Hr.DB.Implementations.Repositories
{
    public class SettlementRepository : Repository<Settlement>, ISettlementRepository
    {
        public SettlementRepository(DataContext context) : base(context)
        {

        }

        public DataContext SettlementContext => Context as DataContext;
    }
}
