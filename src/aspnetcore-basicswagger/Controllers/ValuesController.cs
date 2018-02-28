using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace AspnetCoreBasicSwagger.Controllers
{
    /// <summary>
    /// Test Comment For Controller
    /// </summary>
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ValuesController : Controller
    {
        /// <summary>
        /// This method use the comment
        /// </summary>
        /// <returns>Return an array of string.</returns>
        /// <response code="200">Return an array of string.</response>
        /// <response code="500">Service unavailable.</response>
        /// <response code="403">Service unauthorize.</response>
        [HttpGet]
        [SwaggerResponse(200, Type = typeof(string[]))]
        [SwaggerResponse(500)]
        [SwaggerResponse(403)]
        public IActionResult Get()
        {
            return Ok(new string[] { "value1", "value2" });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
