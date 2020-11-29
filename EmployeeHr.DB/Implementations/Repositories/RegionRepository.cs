using Hr.BL.Entities;
using Hr.BL.Interaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Hr.DB.Implementations.Repositories
{
    public class RegionRepository : Repository<Region>, IRegionRepository
    {
        public RegionRepository(DataContext context) : base(context)
        {

        }

        public new Region Get(int id)
        {
            return RegionContext.Regions.Include(r => r.Municipalities).FirstOrDefault(r => r.Id == id);
        }

        public DataContext RegionContext => Context as DataContext;
    }
}
