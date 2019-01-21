using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebSite.Core
{
    [HtmlTargetElement("video-image-panel")]
    public class VideoImagePanelTagHelper : TagHelper
    {
        public String VideoID { get; set; }
        public Int32 Start { get; set; }
        public Int32 End { get; set; }
        public String ImageUrl { get; set; }

        public VideoImagePanelTagHelper()
        {
        }
        public async override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.Add("class", "video-image-panel");
            output.Attributes.Add("video-image-panel", "true");
            output.Attributes.Add("url", CreateVideoUrl(this.VideoID, this.Start, this.End));
            {
                var img = CreateImage(this.ImageUrl);
                output.Content.AppendHtml(img);
            }
            await base.ProcessAsync(context, output);
        }
        public static String CreateVideoUrl(String id, Int32 start, Int32 end)
        {
            var url = String.Format("//www.youtube.com/embed/{0}?start={1}&end={2}&rel=0&autoplay=1"
                , id, start, end);
            return url;
        }
        private TagBuilder CreateImage(String url)
        {
            var img = new TagBuilder("img");
            img.Attributes.Add("src", url);
            return img;
        }
    }
}
