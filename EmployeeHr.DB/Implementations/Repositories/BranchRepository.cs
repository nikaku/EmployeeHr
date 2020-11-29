using Hr.BL.Entities;
using Hr.BL.Interaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Hr.DB.Implementations.Repositories
{
    public class BranchRepository : Repository<Branch>, IBranchRepository
    {
        public BranchRepository(DataContext context) : base(context)
        {

        }

        public new Branch Get(int id)
        {
            return BranchContext.Branches.Include(b => b.Address).ThenInclude(a => a.Settlement).FirstOrDefault(x => x.Id == id);
        }

        public DataContext BranchContext => Context as DataContext;
    }
}
