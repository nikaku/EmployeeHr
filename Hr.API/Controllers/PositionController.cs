using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hr.BL.Dtos.Position;
using Hr.Services.PositionService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionController : ControllerBase
    {
        private IPositionService _positionService;

        public PositionController(IPositionService position)
        {
            _positionService = position;
        }

        [HttpPost]
        public IActionResult Create(CreatePostionDto createPostionDto)
        {

            var position = _positionService.Add(createPostionDto);
            return CreatedAtAction(nameof(Get), new { id = position.Id }, position);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var position = _positionService.Get(id);
            if (position == null)
            {
                return NotFound();
            }
            return Ok(position);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var position = _positionService.GetAll();
            return Ok(position);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _positionService.Delete(id);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(UpdatePositionDto updatePositionDto)
        {
            try
            {
                var region = _positionService.Update(updatePositionDto);
                return Ok(region);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
