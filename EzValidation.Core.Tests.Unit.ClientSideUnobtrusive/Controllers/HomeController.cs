using System.Web.Mvc;
using EzValidation.Core.Tests.Unit.Shared.ViewModels;

namespace EzValidation.Core.Tests.Unit.ClientSideUnobtrusive.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View(new ValidationViewModel());
        }
    }
}