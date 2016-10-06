using Microsoft.AspNetCore.Mvc;
using RedditPlaylistCreator.Models;
using RedditPlaylistCreator.Services;
using RedditPlaylistCreator.ViewModels.Home;
using System.Threading.Tasks;

namespace RedditPlaylistCreator.Controllers
{
    public class HomeController : Controller
    {
        private RedditService _redditService;

        public HomeController(RedditService redditService)
        {
            _redditService = redditService;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _redditService.GetRedditPosts("youtubehaiku", TimeScale.Day);

            var youtubeids = _redditService.GetYouTubeIdsFromPosts(result);

            return View(new YouTubeVideosViewModel(youtubeids));
        }
    }
}
