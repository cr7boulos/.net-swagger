using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        /// <summary>
        /// The list of all details
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [SwaggerOperation(Tags = new[] { "Group 1"})]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// This will provide details for the specific ID being passed
        /// </summary>
        /// <param name="id"> Required</param>
        /// <returns></returns>
        // GET api/values/5
        [HttpGet("{id}")]
        [SwaggerOperation(Tags = new[] { "Group 2" })]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        [SwaggerOperation(Tags = new[] { "Group 1", "New Group" })]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        [SwaggerOperation(Tags = new[] { "Group 2" })]
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