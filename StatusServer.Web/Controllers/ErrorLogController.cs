using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using StatusServer.DAL;



namespace StatusServer.Web.Controllers
{
    [Route("api/[controller]")]
    public class ErrorLogController : Controller
    {

		[HttpPost()]
		public void RecordError(int project, string env, [FromBody]Error errorInfo)
		{
			var dal = new DAL.ErrorRepository();
			dal.RecordError(errorInfo);
        }


		// GET: api/values
		[HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
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



        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
