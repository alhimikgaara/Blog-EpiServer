using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace Blog.Models.Blocks
{
    [ContentType(DisplayName = "ArticleBlock", GUID = "d9ea8174-88f8-4224-a9d7-241347aab475", Description = "")]
    public class MenuBlock : BlockData
    {
        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "Name field's Title",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Title { get; set; }

        [BackingType(typeof(PropertyUrl))]
        public virtual Url Url { get; set; }

    }
}