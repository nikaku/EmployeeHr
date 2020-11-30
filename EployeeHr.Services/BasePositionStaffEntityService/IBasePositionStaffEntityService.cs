using Hr.BL.Dtos.BasePositionStaffEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr.Services.BasePositionStaffEntityService
{
    public interface IBasePositionStaffEntityService
    {
        GetBasePositionStaffEntityDto Add(CreateBasePositionStaffEntityDto createBasePositionStaffEntityDto);
        GetBasePositionStaffEntityDto Get(int id);
        IEnumerable<GetBasePositionStaffEntityDto> GetAll();
        void Delete(int id);
        GetBasePositionStaffEntityDto Update(UpdateBasePositionStaffEntityDto updateBasePositionStaffEntityDto);
    }
}
