using Hr.BL.Dtos.Position;
using System.Collections.Generic;

namespace Hr.Services.PositionService
{
    public interface IPositionService
    {
        GetPositionDto Add(CreatePostionDto createPostionDto);
        GetPositionDto Get(int id);
        IEnumerable<GetPositionDto> GetAll();
        void Delete(int id);
        GetPositionDto Update(UpdatePositionDto updatePositionDto);
    }
}
