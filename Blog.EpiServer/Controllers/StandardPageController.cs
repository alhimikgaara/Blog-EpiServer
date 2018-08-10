using System.Web.Mvc;
using EPiServer.Web.Mvc;

namespace Blog.EpiServer.Controllers
{
    public class StandardPageController : PageController<Models.Pages.StandardPage>
    {
        public ActionResult Index(Models.Pages.StandardPage currentPage)
        {
            return View(currentPage);
        }
    }
}