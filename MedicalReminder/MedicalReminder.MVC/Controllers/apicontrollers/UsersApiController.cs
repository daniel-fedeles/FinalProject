using MedicalReminder.DAL.Interfaces;
using MedicalReminder.DAL.Repository;
using MedicalReminder.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace MedicalReminder.MVC.Controllers.apicontrollers
{
    public class UsersApiController : ApiController
    {
        private log4net.ILog log;
        private UserServices u;
        private readonly IUserRepository userRepo;
        private readonly IPrescriptionRepository preRepo;
        private readonly IDrugRepository drugRepo;
        private readonly IDoctorRepository docRepo;
        private Guid uguid = Guid.Parse("43AA5D6A-6FDC-489F-8907-EE48AAF06D68");

        public UsersApiController()
        {
            log = log4net.LogManager.GetLogger(typeof(UsersApiController));
            userRepo = new UsersReposatory();
            preRepo = new PrescriptionRepository();
            drugRepo = new DrugRepository();
            docRepo = new DoctorRepository();
            u = new UserServices(userRepo, preRepo, drugRepo, docRepo);
        }

        // GET: api/UsersApi
        public IEnumerable<string> Get()
        {
            log.Info(JsonConvert.SerializeObject(u.GetCurrentUserWithPrescriptions(uguid)));
            return new string[] { JsonConvert.SerializeObject(u.GetCurrentUserWithPrescriptions(uguid)) };
        }

        // GET: api/UsersApi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/UsersApi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/UsersApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/UsersApi/5
        public void Delete(int id)
        {
        }
    }
}
