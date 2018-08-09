using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace Blog.Models.Media
{
    [ContentType(DisplayName = "ImageFile", GUID = "e39fd627-3335-4c96-9aa9-62b1ffe0b85a", Description = "")]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,jpe,ico,gif,bmp,png")]
    public class ImageFile : ImageData
    {
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
    }
}