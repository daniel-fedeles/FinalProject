using MedicalReminder.DAL.Interfaces;
using MedicalReminder.DAL.Repository;
using Newtonsoft.Json;
using System.Web.Mvc;

namespace MedicalReminder.MVC.Controllers.controllers
{
    public class PrescriptionsController : Controller
    {
        private log4net.ILog log;
        private IPrescriptionRepository prescription;
        public PrescriptionsController()
        {
            log = log4net.LogManager.GetLogger(typeof(PrescriptionsController));
            prescription = new PrescriptionRepository();
        }
        // GET: Prescriptions
        public ActionResult Index()
        {
            log.Info(JsonConvert.SerializeObject(prescription.GetAll()));
            return View(prescription.GetAll());
        }

        // GET: Prescriptions/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Prescriptions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Prescriptions/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Prescriptions/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Prescriptions/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Prescriptions/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Prescriptions/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
