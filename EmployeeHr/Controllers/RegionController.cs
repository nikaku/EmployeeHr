using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hr.BL.Dtos.Region;
using EployeeHr.Services.RegionService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private IRegionService _regionService;

        public RegionController(IRegionService regionService)
        {
            _regionService = regionService;
        }

        [HttpPost]
        public IActionResult Create(CreateRegionDto regionDto)
        {
            var region = _regionService.Add(regionDto);
            return CreatedAtAction(nameof(Get), new { id = region.Id }, region);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var region = _regionService.Get(id);
            if (region == null)
            {
                return NotFound();
            }
            return Ok(region);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var regions = _regionService.GetAll();
            return Ok(regions);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _regionService.Delete(id);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(UpdateRegionDto updateRegionDto)
        {
            try
            {
                var region = _regionService.Update(updateRegionDto);
                return Ok(region);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
