using RedditPlaylistCreator.Models;
using System.Collections.Generic;

namespace RedditPlaylistCreator.Services
{
    public class RedditService
    {

        public IEnumerable<Post> GetRedditPosts(string subreddit, TimeScale timeScale, int count = 25)
        {
            string RedditUrl = $"https://www.reddit.com/r/{subreddit}/.json?sort=top&t={timeScale.ToString()}&limit={count}";

            //var webRequestResult = WebRequest

            return null;
        }
    }
}
