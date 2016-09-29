using Microsoft.AspNetCore.Mvc;
using RedditPlaylistCreator.Models;
using RedditPlaylistCreator.Services;
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
            var service = new RedditService();
            var result = await service.GetRedditPosts("youtubehaiku", TimeScale.Day);

            var youtubeids = service.GetYouTubeIdsFromPosts(result);

            return View();
        }
    }
}
