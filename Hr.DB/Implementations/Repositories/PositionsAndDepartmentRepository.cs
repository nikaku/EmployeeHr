using Hr.BL.Entities;
using Hr.BL.Interaces.Repositories;

namespace Hr.DB.Implementations.Repositories
{
    public class PositionsAndDepartmentRepository : Repository<PositionsAndDepartments>, IPositionsAndDepartmentRepository
    {
        public PositionsAndDepartmentRepository(DataContext context) : base(context)
        {

        }

        public DataContext PositionsAndDepartmentContext => Context as DataContext;
    }
}
