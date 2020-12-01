using Hr.BL.Entities;
using Hr.BL.Interaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Hr.DB.Implementations.Repositories
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(DataContext context) : base(context)
        {

        }

        public new Department Get(int id)
        {
            return DepartmentContext.Departments
                .Include(b => b.DepartmentsAndBranches).ThenInclude(b=>b.Branch)
                .FirstOrDefault(x => x.Id == id);        
        }

        public DataContext DepartmentContext => Context as DataContext;
    }
}
