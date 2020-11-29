using EmployeeHr.BL.Dtos.Municipality;
using EmployeeHr.BL.Entities;
using System.Collections.Generic;

namespace EployeeHr.Services.MunicipalityServie
{
    public interface IMunicipalityService
    {
        GetMunicipalityDto Add(CreateMunicipalityDto regionDto);
        GetMunicipalityDto Get(int id);
        IEnumerable<GetMunicipalityDto> GetAll();
        void Delete(int id);
        GetMunicipalityDto Update(UpdateMunicipalityDto region);
    }
}
