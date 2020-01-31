using System.Web.Mvc;

namespace MedicalReminder.MVC.Controllers.controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
