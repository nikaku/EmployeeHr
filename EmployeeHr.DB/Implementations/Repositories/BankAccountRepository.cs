using Hr.BL.Entities;
using Hr.BL.Interaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Hr.DB.Implementations.Repositories
{
    public class BankAccountRepository : Repository<BankAccount>, IBankAccountRepository
    {
        public BankAccountRepository(DataContext context) : base(context)
        {

        }

        public new BankAccount Get(int id)
        {
            return BankAccountContext.BankAccounts.Include(b => b.Branch).FirstOrDefault(b => b.Id == id);
        }

        public DataContext BankAccountContext => Context as DataContext;
    }
}
