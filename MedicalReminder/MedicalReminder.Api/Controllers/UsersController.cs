using MedicalReminder.DAL;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Web.Http;
[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace MedicalReminder.Api.Controllers
{
    public class UsersController : ApiController
    {
        private log4net.ILog log = log4net.LogManager.GetLogger(typeof(UsersController));
        // GET: api/Users
        public IEnumerable<string> Get()
        {
            log.Info("OK");
            UsersRepository u = new UsersRepository();
            log.Info(u.GetAllUsers());
            return new[] { JsonConvert.SerializeObject(u.GetAllUsers()) };
        }

        // GET: api/Users/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Users
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
        }
    }
}
