using System.Web.Mvc;
using Blog.Models.Blocks;
using EPiServer.Web.Mvc;

namespace Blog.EpiServer.Controllers.StandardPage.Articles
{
    public class MenuBlockController : BlockController<MenuBlock>
    {
        public ActionResult MenuBlock(MenuBlock currentPage)
        {
            return PartialView(currentPage);
        }
    }
}