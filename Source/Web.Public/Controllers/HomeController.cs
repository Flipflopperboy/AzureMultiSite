using System.Web.Mvc;
using Web.ModelBuilders;

namespace Web.Public.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View(new HomeIndexViewModelBuilder().Build());
		}
	}
}