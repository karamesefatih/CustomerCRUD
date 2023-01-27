using Bussiness.Abstract;
using DataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
[ApiController]
public class CustomerController : ControllerBase
{
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _customerService.GetAll();
            if (result.Success) return Ok(result);
            return BadRequest();
        }
        [HttpPost]
        public IActionResult Post(tb_customer tb_Customer)
        {
            var result = _customerService.Add_Customer(tb_Customer);
            if (result.Success) return Ok(result);
            return BadRequest();
        }
        [HttpPut]
        public IActionResult Put(tb_customer tb_Customer)
        {
            var result = _customerService.Update_Customer(tb_Customer);
            if (result.Success) return Ok(result);
            return BadRequest();
        }
        [HttpDelete]
        public IActionResult Delete(tb_customer tb_Customer)
        {
            var result = _customerService.Delete_Customer(tb_Customer);
            if (result.Success) return Ok(result);
            return BadRequest();
        }
    }
}
