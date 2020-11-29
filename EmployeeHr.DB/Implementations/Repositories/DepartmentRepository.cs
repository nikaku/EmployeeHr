using Hr.BL.Entities;
using Hr.BL.Interaces.Repositories;

namespace Hr.DB.Implementations.Repositories
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(DataContext context) : base(context)
        {

        }

        public DataContext DepartmentContext => Context as DataContext;
    }
}
