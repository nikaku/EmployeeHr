using Hr.BL.Dtos.Address;
using EployeeHr.Services.AddressService;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Hr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private IAddressService _addresService;
        public AddressController(IAddressService addressService)
        {
            _addresService = addressService;
        }

        [HttpPost]
        public IActionResult Create(CreateAddressDto createAddressDto)
        {
            var address = _addresService.Add(createAddressDto);
            return CreatedAtAction(nameof(Get), new { id = address.Id }, address);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var address = _addresService.Get(id);
            if (address == null)
            {
                return NotFound();
            }
            return Ok(address);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var addresses = _addresService.GetAll();
            return Ok(addresses);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _addresService.Delete(id);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(UpdateAddressDto updateAddressDto)
        {
            try
            {
                var addressDto = _addresService.Update(updateAddressDto);
                return Ok(addressDto);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
