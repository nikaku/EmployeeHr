using EmployeeHr.BL.Entities;
using EmployeeHr.BL.Interaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EmployeeHr.DB.Implementations.Repositories
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        public AddressRepository(DataContext context) : base(context)
        {

        }

        public new Address Get(int id)
        {
            return AddressContext.Addresses.Include(a => a.Settlement).FirstOrDefault(a => a.Id == id);
        }

        public DataContext AddressContext => Context as DataContext;
    }
}
