using EmployeeHr.BL.Entities;
using EmployeeHr.BL.Interaces.Repositories;

namespace EmployeeHr.DB.Implementations.Repositories
{
    public class BankAccountRepository : Repository<BankAccount>, IBankAccountRepository
    {
        public BankAccountRepository(DataContext context) : base(context)
        {

        }

        public DataContext BankAccountContext => Context as DataContext;
    }
}
