using Hr.BL.Entities;
using Hr.BL.Interaces.Repositories;

namespace Hr.DB.Implementations.Repositories
{
    public class BasePositionStaffEntityRepository : Repository<BasePositionStaffEntity>, IBasePositionStaffEntityRepositorty
    {
        public BasePositionStaffEntityRepository(DataContext context) : base(context)
        {
        }

        public DataContext BasePositionStaffEntityContext => Context as DataContext;

    }
}
