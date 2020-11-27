using Demo.Api.Helper;
using System;
using System.Web.Http;

namespace Demo.Api.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly ApiReturn _return;
        public ValuesController(ApiReturn apiReturn)
        {
            _return = apiReturn;
        }
        // GET api/values
        [HttpPost]
        [Route("api/GetValues")]
        public IHttpActionResult Get( dynamic obj)
        {
            try
            {
                _return.ApiData = "Shit! It happened man.";
                _return.IsError = false;
                return Json(_return);
            }
            catch (Exception ex)
            {
                Error.ErrorLog("Something", ex.Message);
                return Json(_return);
            }
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
