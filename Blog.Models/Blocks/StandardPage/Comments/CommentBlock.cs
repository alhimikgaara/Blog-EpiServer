using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Blog.Models.Blocks.StandardPage.Comments
{
    [ContentType(DisplayName = "CommentBlock", GUID = "082a16d1-140e-480a-8018-e9b3bf462f70", Description = "")]
    public class CommentBlock : BlockData
    {
        [CultureSpecific]
        [Display(
            Name = "Author",
            Description = "Name field's Author",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString Author { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Text",
            Description = "Name field's Text",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual XhtmlString Text { get; set; }
    }
}