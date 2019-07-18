using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
namespace DotnetcoreCicdReferenceImplementation.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public static ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public static ActionResult<string> Get(int id)
        {
            return $"value {id}";
        }
    }
}
