using Microsoft.AspNetCore.Mvc;
using NineStarKi.Models;
using System.Linq;

namespace NineStarKi.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository { get; set; }

        public HomeController(IRepository repoService)
        {
            repository = repoService;
        }

        public ViewResult Index() => View();
    }
}
