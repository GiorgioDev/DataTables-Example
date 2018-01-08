using System;
using System.Collections.Generic;
using System.Web.Mvc;
using TestApp.Models;

namespace TestApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Events");
        }

        public ActionResult Events()
        {

            ViewBag.Message = "Your event page.";

            return View();
        }

        [OutputCache(CacheProfile = "CacheEvents")]
        public JsonResult CustomServerSideSearchAction(DataTableAjaxPostModel model)
        {

            //TODO implement the result base on the filter(now is returning always the same results)

            var res = SetupMockupData();

            return Json(new
            {
                aaData = res
            }, JsonRequestBehavior.AllowGet);
        }

        private List<EventModel> SetupMockupData()
        {

            var list = new List<EventModel>();
            for (var i = 0; i < 10000; i++)
            {
                var eventModel = new EventModel
                {
                    EventTitle = "Event Demo N° " + i,
                    RegistrationLink = "www.google.com",
                    StartingDate = DateTime.Today.AddDays(i).ToString(),
                    Technology = ".NET"

                };
                list.Add(eventModel);
            }
            return list;

        }
    }
}