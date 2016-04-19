using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MarkGuttman.CoinApp.Controllers
{
    public class ChangeController : ApiController
    {
        // GET: api/Change
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Change/5
        public string Get(int id)
        {

            return "value";
        }

        // POST: api/Change
        public void Post([FromBody]string value)
        {
            

        }

        // PUT: api/Change/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Change/5
        public void Delete(int id)
        {
        }
    }
}
