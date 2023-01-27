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
        public IActionResult Get()
        {
            var result = _customerService.GetAll();
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }
        [HttpGet("getByCustomerName/{customerName}")]
        public IActionResult getByName(string customerName)
        {

            var resullt = _customerService.GetByCustomerName(customerName);
            if (resullt.Success) return Ok(resullt);
            return BadRequest(resullt);
        }
        [HttpPost]
        public IActionResult Post(tb_customer tb_Customer)
        {
            Console.WriteLine(tb_Customer.name);
            return Ok("SDAASDSA");
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
