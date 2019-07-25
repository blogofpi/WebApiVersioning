using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApiVersioning.Controllers
{
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesMethodController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Response from Version-1 method";
        }

        [HttpGet, MapToApiVersion("2.0")]
        public ActionResult<string> GetV2()
        {
            return "Response from Version-2 method";
        }
    }
}



