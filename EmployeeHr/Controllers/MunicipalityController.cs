using EmployeeHr.BL.Dtos.Municipality;
using EployeeHr.Services.MunicipalityServie;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EmployeeHr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MunicipalityController : ControllerBase
    {
        private IMunicipalityService _municipalityService;
        public MunicipalityController(IMunicipalityService municipalityService)
        {
            _municipalityService = municipalityService;
        }

        [HttpPost]
        public IActionResult Create(CreateMunicipalityDto createMunicipalityDto)
        {
            var municipality = _municipalityService.Add(createMunicipalityDto);
            return CreatedAtAction(nameof(Get), new { id = municipality.Id }, municipality);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var municipality = _municipalityService.Get(id);
            if (municipality == null)
            {
                return NotFound();
            }
            return Ok(municipality);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var regions = _municipalityService.GetAll();
            return Ok(regions);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _municipalityService.Delete(id);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(UpdateMunicipalityDto municipalityDto)
        {
            try
            {
                var region = _municipalityService.Update(municipalityDto);
                return Ok(region);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
