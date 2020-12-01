using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hr.BL.Dtos.BankAccount;
using Hr.Services.BankAccountService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountController : ControllerBase
    {
        private IBankAccountService _bankAccountService;
        public BankAccountController(IBankAccountService bankAccountService)
        {
            _bankAccountService = bankAccountService;
        }
        [HttpPost]
        public IActionResult Create(CreateBankAccountDto createBankAccountDto)
        {
            var bankAccount = _bankAccountService.Add(createBankAccountDto);
            return CreatedAtAction(nameof(Get), new { id = bankAccount.Id }, bankAccount);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var bankAccount = _bankAccountService.Get(id);
            if (bankAccount == null)
            {
                return NotFound();
            }
            return Ok(bankAccount);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var bankAccounts = _bankAccountService.GetAll();
            return Ok(bankAccounts);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _bankAccountService.Delete(id);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(UpdateBankAccountDto updateBankAccountDto)
        {
            try
            {
                var bankAccountDto = _bankAccountService.Update(updateBankAccountDto);
                return Ok(bankAccountDto);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
