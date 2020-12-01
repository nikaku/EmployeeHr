using Hr.BL.Entities;
using Hr.BL.Interaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Hr.DB.Implementations.Repositories
{
    public class BasePositionStaffEntityRepository : Repository<BasePositionStaffEntity>, IBasePositionStaffEntityRepositorty
    {
        public BasePositionStaffEntityRepository(DataContext context) : base(context)
        {
        }

        public new BasePositionStaffEntity Get(int id)
        {
            return BasePositionStaffEntityContext.BasePositionStaffEntities.Include(b => b.PositionsAndDepartments).ThenInclude(x => x.Position).FirstOrDefault(b => b.Id == id);
        }

        public DataContext BasePositionStaffEntityContext => Context as DataContext;

    }
}
