using Hr.BL.Entities;
using Hr.BL.Interaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Hr.DB.Implementations.Repositories
{
    public class MunicipalityRepository : Repository<Municipality>, IMunicipalityRepository
    {
        public MunicipalityRepository(DataContext context) : base(context)
        {

        }

        public new Municipality Get(int id)
        {
            return MunicipalityContext.Municipalities.Include(s => s.Settlements).FirstOrDefault(m => m.Id == id);
        }

        public DataContext MunicipalityContext => Context as DataContext;
    }
}
