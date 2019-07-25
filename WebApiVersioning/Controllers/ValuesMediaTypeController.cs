using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApiVersioning.Controllers.V1
{
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesMediaTypeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Response from Version-1";
        }
    }
}

namespace WebApiVersioning.Controllers.V2
{
    [ApiVersion("2.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesMediaTypeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Response from Version-2";
        }
    }
}

