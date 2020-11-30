using Hr.BL.Interaces;
using Hr.BL.Interaces.Repositories;
using Hr.DB.Implementations.Repositories;
using System;

namespace Hr.DB.Implementations
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private DataContext _dataContext;
        public UnitOfWork(DataContext dataContext)
        {
            _dataContext = dataContext;
            BranchRepository = new BranchRepository(dataContext);
            AddressRepository = new AddressRepository(dataContext);
            BankAccountRepository = new BankAccountRepository(dataContext);
            DepartmentRepository = new DepartmentRepository(dataContext);
            MunicipalityRepository = new MunicipalityRepository(dataContext);
            PositionRepository = new PositionRepository(dataContext);
            RegionRepository = new RegionRepository(dataContext);
            SettlementRepository = new SettlementRepository(dataContext);
            BasePositionStaffEntityRepositorty = new BasePositionStaffEntityRepository(dataContext);
        }

        public IBranchRepository BranchRepository { get; }

        public IAddressRepository AddressRepository { get; }

        public IBankAccountRepository BankAccountRepository { get; }

        public IDepartmentRepository DepartmentRepository { get; }

        public IMunicipalityRepository MunicipalityRepository { get; }

        public IPositionRepository PositionRepository { get; }

        public IRegionRepository RegionRepository { get; }

        public ISettlementRepository SettlementRepository { get; }

        public IBasePositionStaffEntityRepositorty BasePositionStaffEntityRepositorty { get; }

        public void Dispose()
        {
            _dataContext.Dispose();
        }

        public void SaveChanges()
        {
            _dataContext.SaveChanges();
        }
    }
}
