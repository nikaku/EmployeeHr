using Hr.BL.Dtos.Department;
using System.Collections.Generic;

namespace Hr.Services.DepartmentService
{
    public interface IDepartmentService
    {
        GetDepartmentDto Add(CreateDepartmentDto createDepartmentDto);
        GetDepartmentDto Get(int id);
        IEnumerable<GetDepartmentDto> GetAll();
        void Delete(int id);
        GetDepartmentDto Update(UpdateDepartmentDto updateDepartmentDto);
    }
}
