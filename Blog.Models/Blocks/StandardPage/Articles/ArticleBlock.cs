using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace Blog.Models.Blocks.StandardPage.Articles
{
    [ContentType(DisplayName = "ArticleBlock", GUID = "d9ea8174-88f8-4224-a9d7-241347aab474", Description = "")]
    public class ArticleBlock : BlockData
    {
        [CultureSpecific]
        [Display(
            Name = "Name",
            Description = "Name field's Title",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString Title { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Name",
            Description = "Name field's Description",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual XhtmlString Description { get; set; }
        
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

    }
}