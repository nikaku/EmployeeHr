using Hr.BL.Interaces.Repositories;

namespace Hr.BL.Interaces
{
    public interface IUnitOfWork
    {
        IBranchRepository BranchRepository { get; }
        IAddressRepository AddressRepository { get; }
        IBankAccountRepository BankAccountRepository { get; }
        IDepartmentRepository DepartmentRepository { get; }
        IMunicipalityRepository MunicipalityRepository { get; }
        IPositionRepository PositionRepository { get; }
        IRegionRepository RegionRepository { get; }
        ISettlementRepository SettlementRepository { get; }
        void SaveChanges();
        void Dispose();
    }
}
