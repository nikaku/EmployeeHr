using Hr.BL.Dtos.BasePositionStaffEntity;
using Hr.Services.BasePositionStaffEntityService;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Hr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasePositionStaffController : ControllerBase
    {
        private IBasePositionStaffEntityService _staffService;
        public BasePositionStaffController(IBasePositionStaffEntityService branIBasePositionStaffEntityServicechService)
        {
            _staffService = branIBasePositionStaffEntityServicechService;
        }

        [HttpPost]
        public IActionResult Create(CreateBasePositionStaffEntityDto createStaf)
        {
            var staff = _staffService.Add(createStaf);
            return CreatedAtAction(nameof(Get), new { id = staff.Id }, staff);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var staff = _staffService.Get(id);
            if (staff == null)
            {
                return NotFound();
            }
            return Ok(staff);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var staff = _staffService.GetAll();
            return Ok(staff);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _staffService.Delete(id);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(UpdateBasePositionStaffEntityDto updateBasePositionStaffEntityDto)
        {
            try
            {
                var basePositionStaffEntityDto = _staffService.Update(updateBasePositionStaffEntityDto);
                return Ok(basePositionStaffEntityDto);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}