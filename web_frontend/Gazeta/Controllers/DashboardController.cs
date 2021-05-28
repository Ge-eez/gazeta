

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gazeta.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult posts()
        {
            return View("posts");
        }

        public IActionResult addPost()
        {
            return View("addPost");
        }


        public IActionResult Profile()
        {
            return View("Profile");
        }
    }
}
