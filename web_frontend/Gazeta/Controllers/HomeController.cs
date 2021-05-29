using Gazeta.Data;
using Gazeta.Data.MInterface;
using Gazeta.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Gazeta.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public GazetaWebContext Context { get; }
        public INewsRepository NewsRepository { get; }

        public HomeController(ILogger<HomeController> logger, GazetaWebContext context, INewsRepository newsRepository)
        {
            _logger = logger;
            Context = context;
            NewsRepository = newsRepository;
        }

        public async Task<IActionResult> Index()
        {

            return View(NewsRepository.LatestNews());
        }

        public IActionResult Explore()
        {
            return View();
        }
        public IActionResult Subscription()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
