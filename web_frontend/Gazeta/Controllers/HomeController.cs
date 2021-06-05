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
        public INewsRepository NewsRepository { get; }
        public ISubscriptionRepository SubscriptionRepository { get; }
        public IUserAccount UserAccount { get; }

        public HomeController(INewsRepository newsRepository,
                            ISubscriptionRepository subscriptionRepository,
                            IUserAccount userAccount)
        {
            NewsRepository = newsRepository;
            SubscriptionRepository = subscriptionRepository;
            UserAccount = userAccount;
        }

        public IActionResult Index()
        {
            

            if (TempData["email"] != null) return View(NewsRepository.LatestNews());
            return RedirectToAction(nameof(LoginUser));
        }

        public IActionResult Explore()
        {
            if (TempData["email"] == null) return RedirectToAction(nameof(LoginUser));
            return View(NewsRepository.GetNewsMostLiked());

        }

        public ActionResult Subscription(string company)
        {
            if (TempData["email"] == null) return RedirectToAction(nameof(LoginUser));

            string email = TempData["email"].ToString();
            dynamic MyModels = new System.Dynamic.ExpandoObject();
            MyModels.Subscription = null;
            MyModels.News = null;
            IEnumerable<News> SubscribedNews = null;
            IEnumerable<Subscription> subscriptions = SubscriptionRepository.GetSubscribedNewsCompany(email);
            if (subscriptions.Count() == 0) return View(MyModels);

            if (company == null)
            {

                Subscription first = subscriptions.First();
                SubscribedNews = NewsRepository.GetNewsByCompany(first.CompanyEmail);
            }
            else
            {
                company = company.ToString();
                SubscribedNews = NewsRepository.GetNewsByCompany(company);
            }


            MyModels.Subscription = subscriptions;
            MyModels.News = SubscribedNews;

            return View(MyModels);

        }
        public ActionResult Subscribe(string id)
        {
            int Id = Int32.Parse(id);

            var news = NewsRepository.GetNews(Id);
            if (news == null) return RedirectToAction(nameof(Index));
            SubscriptionRepository.SubscribeNews(TempData["email"].ToString(), news.CompanyName,news.CompanyEmail);

            bool subscribed = SubscriptionRepository.CheckSubscription(news.CompanyName, TempData["email"].ToString());
            if (subscribed) ViewBag.subscribed = "subscribed";
            else ViewBag.subscribed = "unsubscribed";

            return View("Details", news);

        }
        //add the Unsubscribe funciton
        public ActionResult Unsubscribe(int? id)
        {
            

            var news = NewsRepository.GetNews(id);
            if (news == null) return RedirectToAction(nameof(Index));
            SubscriptionRepository.UnubscribeNews(TempData["email"].ToString(), news.CompanyName);

            bool subscribed = SubscriptionRepository.CheckSubscription(news.CompanyName, TempData["email"].ToString());
            if (subscribed) ViewBag.subscribed = "subscribed";
            else ViewBag.subscribed = "unsubscribed";

            return View("Details", news);

        }


        public ActionResult Gener(string topic)
        {
            if (TempData["email"] == null) return RedirectToAction(nameof(LoginUser));

            string gener = topic;
            if (gener == null) return View("Index");
            var news = NewsRepository.GetNewsByGenre(gener);
            ViewBag.topic = topic;
            return View(news);
        }

        //replace below functions of authentication
        public ActionResult LoginUser()
        {
            if (TempData["email"] != null) return RedirectToAction(nameof(Index));
            return View();
        }

        [HttpPost]
        public ActionResult LoginUser(string email, string password)
        {
            try
            {
                var user = UserAccount.UserLogin(email.ToString(), password.ToString());
                if (user == null) return View();
                TempData["name"] = user["name"];
                TempData["email"] = user["email"];
                
                
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterUser([Bind("UserName,UserEmail,UserPassword")] User user)
        {
            if (ModelState.IsValid)
            {
                UserAccount.RegisterUser(user);
                return RedirectToAction(nameof(RegisterUser));
            }
            return RedirectToAction(nameof(LoginUser));
        }
        //public ActionResult Login()
        //{
        //    if (TempData["email"] != null) return RedirectToAction(nameof(Index));
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult Login(string email, string password)
        //{
        //    try
        //    {

        //        var user = UserAccount.UserLogin(email, password);
        //        if (user == null) return View();
        //        TempData["name"] = user["name"];
        //        TempData["email"] = user["email"];

        //        return RedirectToAction(nameof(Index));


        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //}
        //public ActionResult Register()
        //{
            
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult Register(string name, string email, string password)
        //{
        //    User user = new User();
        //    user.UserName = name;
        //    user.UserEmail = email;
        //    user.UserPassword = password;

        //    if (email != null && name != null && password != null)
        //    {
        //        UserAccount.RegisterUser(user);
        //        return RedirectToAction(nameof(Login));
        //    }

        //    return View();
        //}

        public ActionResult Search(string searchArg)
        {
            if (TempData["email"] == null) return RedirectToAction(nameof(LoginUser));

            if (searchArg != null)
            {
                var result = NewsRepository.Search(searchArg);
                return View(result);
            }
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Details(int? id)
        {
            if (TempData["email"] == null) return RedirectToAction(nameof(LoginUser));
            var news = NewsRepository.NewsDetail(id);
            
            if (news == null) return RedirectToAction(nameof(Index));

            bool subscribed = SubscriptionRepository.CheckSubscription(news.CompanyName, TempData["email"].ToString());
            if(subscribed) ViewBag.subscribed = "subscribed";
            else ViewBag.subscribed = "unsubscribed";

            return View(news);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult Logout()
        {
            TempData["name"] = null;
            TempData["email"] = null;
            return RedirectToAction(nameof(Index));
        }
        public ActionResult GetSubscribed()
        {
            var s = SubscriptionRepository.GetSubscribedNews();
            return View(s);
        }
    }
}
