using EmployeeHr.BL.Dtos.Settlement;
using EmployeeHr.BL.Interaces;
using EployeeHr.Services.SettlementService;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EmployeeHr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettlementController : ControllerBase
    {
        private ISettlementService _settlementService;
        public SettlementController(ISettlementService settlementService)
        {
            _settlementService = settlementService;
        }

        [HttpPost]
        public IActionResult CreateSettlement(CreateSettlementDto createSettlementDto)
        {
            var settlment = _settlementService.Add(createSettlementDto);
            return CreatedAtAction(nameof(Get), new { id = settlment.Id }, settlment);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var region = _settlementService.Get(id);
            if (region == null)
            {
                return NotFound();
            }
            return Ok(region);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var settlements = _settlementService.GetAll();
            return Ok(settlements);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _settlementService.Delete(id);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(UpdateSettlementDto settlementDto)
        {
            try
            {
                var region = _settlementService.Update(settlementDto);
                return Ok(region);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
