using Hr.BL.Dtos.Municipality;
using System.Collections.Generic;

namespace EployeeHr.Services.MunicipalityServie
{
    public interface IMunicipalityService
    {
        GetMunicipalityDto Add(CreateMunicipalityDto createMunicipalityDto);
        GetMunicipalityDto Get(int id);
        IEnumerable<GetMunicipalityDto> GetAll();
        void Delete(int id);
        GetMunicipalityDto Update(UpdateMunicipalityDto updateMunicipalityDto);
    }
}
