using Hr.BL.Dtos.Branch;
using System.Collections.Generic;

namespace EployeeHr.Services.BranchService
{
    public interface IBranchService
    {
        GetBranchDto Add(CreateBranchDto branchDto);
        GetBranchDto Get(int id);
        IEnumerable<GetBranchDto> GetAll();
        void Delete(int id);
        GetBranchDto Update(UpdateBranchDto branch);
    }
}
