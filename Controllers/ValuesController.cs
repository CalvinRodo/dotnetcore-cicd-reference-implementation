using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
namespace DotnetcoreCicdReferenceImplementation.Controllers
{

    /// <summary>
    /// An example api controller
    ///</summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
    /// <summary>
    /// GET api/values
    /// </summary>
    [HttpGet]
    public static ActionResult<IEnumerable<string>> Get() => new string[] { "value1", "value2" };


    /// <summary>
    /// GET api/values/5
    /// </summary>
    [HttpGet("{id}")]
    public static ActionResult<string> Get(int id) => $"value {id}";
  }
}
