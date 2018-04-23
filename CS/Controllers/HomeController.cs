using System;
using System.Web.Mvc;
using Sample.Models;

namespace GridViewLinkColumnMvc.Controllers {
    public class HomeController : Controller {
        PersonsList personsList = new PersonsList();
        
        public ActionResult Index() {
            return View();
        }

        public ActionResult GridViewPartial() {
            return PartialView(personsList.GetPersons());
        }

        public ActionResult Details(object id) {
            return View(id);
        }
    }
}