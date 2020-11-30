using Hr.BL.Dtos.Department;
using Hr.Services.DepartmentService;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Hr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpPost]
        public IActionResult Create(CreateDepartmentDto departmentDto)
        {
            var result = _departmentService.Add(departmentDto);
            return CreatedAtAction(nameof(Get), new { id = result.Id }, result);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var department = _departmentService.Get(id);

            if (department == null)
            {
                return NotFound();
            }

            return Ok(department);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var departments = _departmentService.GetAll();
            return Ok(departments);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _departmentService.Delete(id);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(UpdateDepartmentDto updateDepartmentDto)
        {
            try
            {
                var departmentDto = _departmentService.Update(updateDepartmentDto);
                return Ok(departmentDto);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
