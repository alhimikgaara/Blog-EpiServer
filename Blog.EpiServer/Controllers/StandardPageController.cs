using System.Web.Mvc;
using Blog.Models.Pages;
using EPiServer.Web.Mvc;

namespace Blog.EpiServer.Controllers
{
    public class StandardPageController : PageController<StandardPage>
    {
        public ActionResult Index(StandardPage currentPage)
        {
            return View(currentPage);
        }
    }
}