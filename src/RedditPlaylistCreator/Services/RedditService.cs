using Newtonsoft.Json.Linq;
using RedditPlaylistCreator.Models;
using RedditPlaylistCreator.Models.RedditModels;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace RedditPlaylistCreator.Services
{
    public class RedditService
    {

        public async Task<IEnumerable<Post>> GetRedditPosts(string subreddit, TimeScale timeScale, int count = 25)
        {
            string RedditUrl = $"https://www.reddit.com/r/{subreddit}/.json?sort=top&t={timeScale.ToString()}&limit={count}";

            var result = await GetResponseFromUrl(RedditUrl);
            var jsonObject = JObject.Parse(result).ToObject<RedditListingResponseJson>();

            return jsonObject.data.children.Select(postHeader => new Post
            {
                Title = postHeader.data.title,
                Link = postHeader.data.url,
                Score = postHeader.data.score
            }).ToList();
        }

        private async Task<string> GetResponseFromUrl(string url)
        {
            var webRequest = WebRequest.Create(url);
            var response = await webRequest.GetResponseAsync();
            var streamReader = new StreamReader(response.GetResponseStream());
            return streamReader.ReadToEnd();
        }
    }
}
