using EmployeeHr.BL.Entities;
using EmployeeHr.BL.Interaces.Repositories;

namespace EmployeeHr.DB.Implementations.Repositories
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(DataContext context) : base(context)
        {

        }

        public DataContext DepartmentContext => Context as DataContext;
    }
}
