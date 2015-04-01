using System.Web.Mvc;

namespace CRM_team.Web.Controllers
{
    public class HomeController : CRM_teamControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}