using Hr.BL.Entities;
using Hr.BL.Interaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Hr.DB.Implementations.Repositories
{
    public class PositionRepository : Repository<Position>, IPositionRepository
    {
        public PositionRepository(DataContext context) : base(context)
        {

        }

        public new Position Get(int id)
        {
            return PositonContext.Positions
                .Include(x => x.PositionsAndDepartments)
                .ThenInclude(b => b.Branch)
                .Include(x => x.PositionsAndDepartments)
                .ThenInclude(d => d.Department)
                .FirstOrDefault(x => x.Id == id);
        }

        public DataContext PositonContext => Context as DataContext;
    }
}
