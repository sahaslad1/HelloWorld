using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SwaggerWebApi.Controllers
{
    public class SampleController : ApiController
    {
        // GET api/<controller>
        /// <summary>
        /// This method returns back all the stored values
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        /// <summary>
        /// This Get method with Id return details for the specific ID.
        /// Id is a required field here.
        /// </summary>
        /// <param name="id">It is Required Field.</param>
        /// <returns></returns>
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}