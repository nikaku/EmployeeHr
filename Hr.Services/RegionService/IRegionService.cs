using Hr.BL.Dtos.Region;
using Hr.BL.Entities;
using System.Collections.Generic;

namespace EployeeHr.Services.RegionService
{
    public interface IRegionService
    {
        GetRegionDto Add(CreateRegionDto regionDto);
        GetRegionDto Get(int id);
        IEnumerable<GetRegionDto> GetAll();
        void Delete(int id);
        GetRegionDto Update(UpdateRegionDto region);
    }
}
