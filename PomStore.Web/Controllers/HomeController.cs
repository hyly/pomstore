using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace PomStore.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : PomStoreControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}