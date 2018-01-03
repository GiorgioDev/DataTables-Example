using System.Collections.Generic;
using System.Web.Mvc;
using TestApp.Models;

namespace TestApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Events()
        {

            var list = SetupMockupData();
            ViewBag.Message = "Your event page.";

            return View();
        }

        private List<EventModel> SetupMockupData()
        {

            var list = new List<EventModel>();
            for (var i = 0; i < 1000; i++)
            {
                var e = new EventModel();
                list.Add(e);
            }
            return list;

        }
    }
}