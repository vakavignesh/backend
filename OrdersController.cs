  ��Ѩ��I��N��̵using System.Collections.Generic;
using api2.Models;
using Microsoft.AspNetCore.Mvc;

namespace api2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        [HttpPost()]
        public IActionResult CreateOrder([FromBody] Order order)
        {
            return Ok();
        }

    }
}