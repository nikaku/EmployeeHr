using Hr.BL.Dtos.Branch;
using EployeeHr.Services.BranchService;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Hr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private IBranchService _branchService;

        public BranchController(IBranchService branchService)
        {
            _branchService = branchService;
        }

        [HttpPost]
        public IActionResult Create(CreateBranchDto createAddressDto)
        {
            var branch = _branchService.Add(createAddressDto);
            return CreatedAtAction(nameof(Get), new { id = branch.Id }, branch);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var branch = _branchService.Get(id);
            if (branch == null)
            {
                return NotFound();
            }
            return Ok(branch);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var branches = _branchService.GetAll();
            return Ok(branches);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _branchService.Delete(id);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(UpdateBranchDto updateAddressDto)
        {
            try
            {
                var addressDto = _branchService.Update(updateAddressDto);
                return Ok(addressDto);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
