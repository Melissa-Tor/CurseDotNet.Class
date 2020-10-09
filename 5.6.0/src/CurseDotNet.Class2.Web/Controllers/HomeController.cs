using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace CurseDotNet.Class2.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : Class2ControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}