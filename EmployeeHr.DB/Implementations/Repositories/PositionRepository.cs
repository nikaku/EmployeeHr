using EmployeeHr.BL.Entities;
using EmployeeHr.BL.Interaces.Repositories;

namespace EmployeeHr.DB.Implementations.Repositories
{
    public class PositionRepository : Repository<Position>, IPositionRepository
    {
        public PositionRepository(DataContext context) : base(context)
        {

        }
        public DataContext PositonContext => Context as DataContext;
    }
}
