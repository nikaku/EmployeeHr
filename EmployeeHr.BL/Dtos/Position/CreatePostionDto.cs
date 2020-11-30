using System;
using System.Collections.Generic;
using System.Text;

namespace Hr.BL.Dtos.Position
{
    public class CreatePostionDto
    {
        public string Name { get; set; }
        public List<int> DepartmentIds { get; set; }
    }
}
