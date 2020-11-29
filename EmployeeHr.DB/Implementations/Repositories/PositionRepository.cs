using Hr.BL.Entities;
using Hr.BL.Interaces.Repositories;

namespace Hr.DB.Implementations.Repositories
{
    public class PositionRepository : Repository<Position>, IPositionRepository
    {
        public PositionRepository(DataContext context) : base(context)
        {

        }
        public DataContext PositonContext => Context as DataContext;
    }
}
