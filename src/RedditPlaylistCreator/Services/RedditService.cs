using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace RedditPlaylistCreator.Services
{
    public class RedditService
    {
        private ILogger<RedditService> _logger;

        public RedditService(ILogger<RedditService> logger)
        {
            _logger = logger;
        }

        public IEnumerable<string> GetTopYouTubeVideosForSubReddit(string subreddit)
        {
            return null;
        }
    }
}
