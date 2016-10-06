using Microsoft.AspNetCore.Html;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace RedditPlaylistCreator.ViewModels.Home
{
    public class YouTubeVideosViewModel
    {
        public YouTubeVideosViewModel() {}

        public YouTubeVideosViewModel(IEnumerable<string> videoIds)
        {
            YouTubeVideoIds = videoIds;
        }

        public IEnumerable<string> YouTubeVideoIds { get; set; }
        public IHtmlContent JsonIds => new HtmlString(JsonConvert.SerializeObject(YouTubeVideoIds));
    }
}
