﻿using System.ComponentModel.DataAnnotations;
using Blog.Models.Blocks;
using Blog.Models.Blocks.StandardPage.Articles;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Blog.Models.Pages
{
    [ContentType(DisplayName = "StandardPage", GUID = "dbc674b2-20cc-434d-8458-090501afb49f", Description = "")]
    public class StandardPage : PageData
    {

        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString Title { get; set; }

        [AllowedTypes(AllowedTypes = new[] { typeof(ArticleBlock) })]
        public virtual ContentArea ArticlesArea { get; set; }

        [AllowedTypes(AllowedTypes = new[] { typeof(MenuBlock) })]
        public virtual ContentArea MenuArea { get; set; }

    }
}