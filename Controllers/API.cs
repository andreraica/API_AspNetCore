using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API_AspNetCore.Controllers
{
    [Route("api/[controller]")]
    public class ExemploAPIController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return new ObjectResult("{ 'teste' : 123 }");
        }

        
    }
}
