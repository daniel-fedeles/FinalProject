using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MedicalReminder.Api.Controllers
{
    public class DoctorsController : ApiController
    {
        // GET: api/Doctors
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Doctors/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Doctors
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Doctors/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Doctors/5
        public void Delete(int id)
        {
        }
    }
}
