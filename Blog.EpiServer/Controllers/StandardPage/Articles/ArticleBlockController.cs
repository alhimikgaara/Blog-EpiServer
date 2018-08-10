using System.Web.Mvc;
using Blog.Models.Blocks.StandardPage.Articles;
using EPiServer;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;

namespace Blog.EpiServer.Controllers.StandardPage.Articles
{
    public class ArticleBlockController : BlockController<ArticleBlock>
    {
        public ActionResult ArticleBlock(ArticleBlock currentPage)
        {
            return PartialView(currentPage);
        }
    }
}