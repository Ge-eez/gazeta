using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Gazeta.Data;
using Gazeta.Models;
using Gazeta.Data.MInterface;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace Gazeta.Controllers
{
    //public class CompanyController : Controller
    //{
    //    private readonly ApplicationDbContext _context;

    //    public IUserAccount UserAccount { get; }
    //    private readonly INewsRepository NewsRepository;
    //    private readonly IWebHostEnvironment _hostEnvironment;

    //    public CompanyController(ApplicationDbContext context,INewsRepository newsRepository, IWebHostEnvironment hostEnvironment, IUserAccount userAccount)
    //    {
    //        _context = context;
    //        UserAccount = userAccount;
    //        _context = context;
    //        NewsRepository = newsRepository;
    //        this._hostEnvironment = hostEnvironment;
    //        UserAccount = userAccount;
    //    }

    //    public async Task<IActionResult> Index()
    //    {
    //        // return View(await _context.News.ToListAsync());
    //        if (TempData["company"] == null) return RedirectToAction(nameof(LoginCompany));
    //        var totalPosts = NewsRepository.GetNewsByCompany(TempData["email"].ToString());
    //        ViewBag.totalPosts = totalPosts.Count();

    //        var totalSubscribers = NewsRepository.GetSubscribersList(TempData["company"].ToString());
    //        ViewBag.totalSubscribers = totalSubscribers.Count();

    //        return View(NewsRepository.MostLikedNews(NewsRepository.GetNewsByCompany(TempData["email"].ToString())));
    //    }

    //    public ActionResult LoginCompany()
    //    {
    //        if (TempData["company"] != null) return RedirectToAction(nameof(Index));
    //        return View();
    //    }

    //    [HttpPost]
    //    public ActionResult LoginCompany(string email, string password)
    //    {
    //        try
    //        {
    //            var company = UserAccount.CompanyLogin(email, password);
    //            if (company == null) return View();
    //            TempData["company"] = company["companyName"];
    //            TempData["email"] = company["email"];
    //            TempData["profile"] = company["profile"];
    //            TempData["owner"] = company["owner"];
                
    //            return RedirectToAction(nameof(Index));
    //        }
    //        catch (Exception)
    //        {
    //            throw;
    //        }
    //    }


    //    // public ActionResult RegisterCompany()
    //    // {

    //    //     return View();
    //    // }

    //    // [HttpPost]
    //    // public ActionResult RegisterCompany(string name,string email, string password, string owner)
    //    // {
    //    //     Company user = new Company();
    //    //     user.CompanyName = name;
    //    //     user.CompanyEmail = email;
    //    //     user.CompanyPassword = password;

    //    //     if (email != null && name != null && password != null)
    //    //     {
    //    //         UserAccount.RegisterCompanies(user);
    //    //         return RedirectToAction(nameof(LoginCompany));
    //    //     }

    //    //     return RedirectToAction(nameof(Index));
    //    // }

    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> RegisterCompany([Bind("CompanyName,CompanyEmail,CompanyPassword,Owner,ProfileImage,ImageFile")] Company company)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            if (company.ImageFile != null)
    //            {
    //                string wwwRootPath = _hostEnvironment.WebRootPath;
    //                string fileName = Path.GetFileNameWithoutExtension(company.ImageFile.FileName);
    //                string extension = Path.GetExtension(company.ImageFile.FileName);
    //                company.ProfileImage = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
    //                string path = Path.Combine(wwwRootPath + "/image/", fileName);
    //                using (var fileStream = new FileStream(path, FileMode.Create))
    //                {
    //                    await company.ImageFile.CopyToAsync(fileStream);
    //                }
    //            }

    //            // company.Likes ??= 0;    

    //            // company.CompanyEmail = "Email";
    //            // company.CompanyName = "Name";
    //            company.ProfileImage = "Aloha";

    //            UserAccount.RegisterCompany(company);
    //            return RedirectToAction(nameof(Index));
    //        }
    //        return RedirectToAction(nameof(Posts));
    //    }




    //    public async Task<IActionResult> Posts()
    //    {
    //        // return View(await _context.News.ToListAsync());
    //        return View(NewsRepository.LatestNews(NewsRepository.GetNewsByCompany(TempData["email"].ToString())));
    //    }

    //    public async Task<IActionResult> Categories(String genre)
    //    {
    //        // return View(await _context.News.ToListAsync());
    //        ViewBag.category = genre;
    //        return View(NewsRepository.GetNewsByGenre(genre));
    //    }

    //    public async Task<IActionResult> Profile(String companyEmail)
    //    {
    //        if (companyEmail == null)
    //        {
    //            return NotFound();
    //        }

    //        var company = NewsRepository.CompanyProfile(companyEmail);
    //        if (company == null)
    //        {
    //            return NotFound();
    //        }

    //        var totalSubscribers = NewsRepository.GetSubscribersList(companyEmail);
    //        ViewBag.totalSubscribers = totalSubscribers.Count();

    //        return View(company);
    //    }

    //    // GET: News/Details/5
    //    public async Task<IActionResult> NewsDetail(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var news = NewsRepository.NewsDetail(id);
    //        if (news == null)
    //        {
    //            return NotFound();
    //        }

    //        return View(news);
    //    }

    //    // GET: News/Create
    //    public IActionResult PostNews()
    //    {
    //        return View();
    //    }

    //    // POST: News/Create
    //    // To protect from overposting attacks, enable the specific properties you want to bind to.
    //    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> PostNews([Bind("NewsId,Headline,ImageURL,Article,PublishDate,CompanyEmail,CompanyName,Likes,Genre,ImageFile")] News news)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            if (news.ImageFile != null)
    //            {
    //                string wwwRootPath = _hostEnvironment.WebRootPath;
    //                string fileName = Path.GetFileNameWithoutExtension(news.ImageFile.FileName);
    //                string extension = Path.GetExtension(news.ImageFile.FileName);
    //                news.ImageURL = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
    //                string path = Path.Combine(wwwRootPath + "/image/", fileName);
    //                using (var fileStream = new FileStream(path, FileMode.Create))
    //                {
    //                    await news.ImageFile.CopyToAsync(fileStream);
    //                }
    //                news.Likes ??= 0;

    //                news.CompanyEmail = TempData["email"].ToString();
    //                news.CompanyName = TempData["company"].ToString();

    //                NewsRepository.PostNews(news);
    //                return RedirectToAction(nameof(Index));
    //            }

                
    //        }
    //        return View(news);
    //    }

    //    // GET: News/Edit/5
    //    public async Task<IActionResult> Edit(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var news = await _context.News.FindAsync(id);
    //        if (news == null)
    //        {
    //            return NotFound();
    //        }
    //        return View(news);
    //    }

    //    // POST: News/Edit/5
    //    // To protect from overposting attacks, enable the specific properties you want to bind to.
    //    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Edit(int id, [Bind("NewsId,Headline,ImageURL,Article,PublishDate,CompanyEmail, CompanyName,Likes")] News news)
    //    {
    //        if (id != news.NewsId)
    //        {
    //            return NotFound();
    //        }

    //        if (ModelState.IsValid)
    //        {
    //            try
    //            {
    //                NewsRepository.EditNews(news);
    //            }
    //            catch (DbUpdateConcurrencyException)
    //            {
    //                if (!NewsExists(news.NewsId))
    //                {
    //                    return NotFound();
    //                }
    //                else
    //                {
    //                    throw;
    //                }
    //            }
    //            return RedirectToAction(nameof(Index));
    //        }
    //        return View(news);
    //    }

    //    // GET: News/Delete/5
    //    public async Task<IActionResult> Delete(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var news = await _context.News
    //            .FirstOrDefaultAsync(m => m.NewsId == id);
    //        if (news == null)
    //        {
    //            return NotFound();
    //        }

    //        return View(news);
    //    }

    //    // POST: News/Delete/5
    //    [HttpPost, ActionName("Delete")]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> DeleteConfirmed(int id)
    //    {
    //        var news = await _context.News.FindAsync(id);

    //        //delete image from wwwroot/image
    //        var imagePath = Path.Combine(_hostEnvironment.WebRootPath, "image", news.ImageURL);
    //        if (System.IO.File.Exists(imagePath))
    //            System.IO.File.Delete(imagePath);

    //        _context.News.Remove(news);
    //        await _context.SaveChangesAsync();
    //        return RedirectToAction(nameof(Index));
    //    }

    //    private bool NewsExists(int id)
    //    {
    //        return _context.News.Any(e => e.NewsId == id);
    //    }
    //    public ActionResult Logout()
    //    {
    //        TempData["company"] = null;
    //        TempData["email"] = null;
    //        TempData["profile"] = null;
    //        TempData["owner"] = null;
    //        return RedirectToAction(nameof(Index));
    //    }

    ////}
}
public class CompanyController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly INewsRepository NewsRepository;

    public IUserAccount UserAccount { get; }
    private readonly IWebHostEnvironment _hostEnvironment;

    public CompanyController(ApplicationDbContext context, INewsRepository newsRepository, IWebHostEnvironment hostEnvironment, IUserAccount userAccount)
    {
        _context = context;
        NewsRepository = newsRepository;
        this._hostEnvironment = hostEnvironment;
        UserAccount = userAccount;
    }

    // GET: News
    public async Task<IActionResult> Index()
    {
        // return View(await _context.News.ToListAsync());
        if (TempData["company"] == null) return RedirectToAction(nameof(LoginCompany));
        var totalPosts = NewsRepository.GetNewsByCompany(TempData["company"].ToString());
        ViewBag.totalPosts = totalPosts.Count();

        var totalSubscribers = NewsRepository.GetSubscribersList(TempData["company"].ToString());
        ViewBag.totalSubscribers = totalSubscribers.Count();

        return View(NewsRepository.MostLikedNews(NewsRepository.GetNewsByCompany(TempData["company"].ToString())));
    }

    public ActionResult LoginCompany()
    {
        if (TempData["company"] != null) return RedirectToAction(nameof(Index));
        return View();
    }

    [HttpPost]
    public ActionResult LoginCompany(string email, string password)
    {
        try
        {
            var company = UserAccount.CompanyLogin(email, password);
            TempData["company"] = company["companyName"];
            TempData["email"] = company["email"];
            TempData["password"] = company["password"];
            TempData["profile"] = company["profile"];
            TempData["owner"] = company["owner"];
            if (company == null) return View();
            return RedirectToAction(nameof(Index));
        }
        catch (Exception)
        {
            return RedirectToAction(nameof(Index));
            throw;
        }
    }

    public ActionResult Logout()
    {
        TempData["company"] = null;
        TempData["email"] = null;
        TempData["password"] = null;
        TempData["profile"] = null;
        TempData["owner"] = null;

        return RedirectToAction(nameof(LoginCompany));
    }

    // public ActionResult RegisterCompany()
    // {

    //     return View();
    // }

    // [HttpPost]
    // public ActionResult RegisterCompany(string name,string email, string password, string owner)
    // {
    //     Company user = new Company();
    //     user.CompanyName = name;
    //     user.CompanyEmail = email;
    //     user.CompanyPassword = password;

    //     if (email != null && name != null && password != null)
    //     {
    //         UserAccount.RegisterCompanies(user);
    //         return RedirectToAction(nameof(LoginCompany));
    //     }

    //     return RedirectToAction(nameof(Index));
    // }

    // [HttpPost]
    // [ValidateAntiForgeryToken]
    // public async Task<IActionResult> RegisterCompany([Bind("CompanyName,CompanyEmail,CompanyPassword,ConfirmPassword,Address,City,Description,Owner,ProfileImage,ImageFile")] Company company)
    // {
    //     if (ModelState.IsValid)
    //     {
    //         if (company.ImageFile != null)
    //         {
    //             string wwwRootPath = _hostEnvironment.WebRootPath;
    //             string fileName = Path.GetFileNameWithoutExtension(company.ImageFile.FileName);
    //             string extension = Path.GetExtension(company.ImageFile.FileName);
    //             company.ProfileImage = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
    //             string path = Path.Combine(wwwRootPath + "/profileImage/",fileName);
    //             using (var fileStream = new FileStream(path, FileMode.Create))
    //             {
    //                 await company.ImageFile.CopyToAsync(fileStream);
    //             }
    //         }

    //         // company.ProfileImage = "Aloha";

    //         NewsRepository.RegisterCompany(company);
    //         return RedirectToAction(nameof(Index));
    //     }
    //     return RedirectToAction(nameof(Index));
    // }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> RegisterCompany([Bind("CompanyName,CompanyEmail,CompanyPassword,ConfirmPassword,Address,City,Description,Owner,ProfileImage,ImageFile")] Company company)
    {
        if (ModelState.IsValid)
        {
            if (company.ImageFile != null)
            {
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(company.ImageFile.FileName);
                string extension = Path.GetExtension(company.ImageFile.FileName);
                company.ProfileImage = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/profileImage/", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await company.ImageFile.CopyToAsync(fileStream);
                }
            }



            _context.Add(company);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return RedirectToAction(nameof(Index));
    }


    public async Task<IActionResult> Posts()
    {
        // return View(await _context.News.ToListAsync());
        return View(NewsRepository.LatestNews(NewsRepository.GetNewsByCompany(TempData["company"].ToString())));
    }

    public async Task<IActionResult> Categories(String genre)
    {
        // return View(await _context.News.ToListAsync());
        ViewBag.category = genre;
        return View(NewsRepository.GetNewsByGenre(genre, NewsRepository.GetNewsByCompany(TempData["company"].ToString())));
    }

    public async Task<IActionResult> Profile(String companyEmail)
    {
        if (companyEmail == null)
        {
            return NotFound();
        }

        var company = NewsRepository.CompanyProfile(companyEmail);
        if (company == null)
        {
            return NotFound();
        }

        var totalSubscribers = NewsRepository.GetSubscribersList(companyEmail);
        ViewBag.totalSubscribers = totalSubscribers.Count();

        return View(company);
    }

    // GET: News/Details/5
    public async Task<IActionResult> NewsDetail(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var news = NewsRepository.NewsDetail(id);
        if (news == null)
        {
            return NotFound();
        }

        return View(news);
    }

    // GET: News/Create
    public IActionResult PostNews()
    {
        return View();
    }

    // POST: News/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> PostNews([Bind("NewsId,Headline,ImageURL,Article,PublishDate,CompanyEmail,CompanyName,Likes,Genre,ImageFile")] News news)
    {
        if (ModelState.IsValid)
        {
            if (news.ImageFile != null)
            {
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(news.ImageFile.FileName);
                string extension = Path.GetExtension(news.ImageFile.FileName);
                news.ImageURL = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/image/", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await news.ImageFile.CopyToAsync(fileStream);
                }
            }

            news.Likes ??= 0;

            news.CompanyEmail = TempData["company"].ToString();
            news.CompanyName = TempData["company"].ToString();

            NewsRepository.PostNews(news);
            return RedirectToAction(nameof(Index));
        }
        return View(news);
    }

    // GET: News/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var news = await _context.News.FindAsync(id);
        if (news == null)
        {
            return NotFound();
        }
        return View(news);
    }

    // POST: News/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("NewsId,Headline,ImageURL,Article,PublishDate,CompanyEmail,CompanyName,Likes")] News news)
    {
        if (id != news.NewsId)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                news.CompanyName = TempData["company"].ToString();
                news.CompanyEmail = TempData["company"].ToString();
                NewsRepository.EditNews(news);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NewsExists(news.NewsId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(news);
    }

    public async void UpdateProfile(Company company)
    {
        _context.Update(company);
        await _context.SaveChangesAsync();
    }

    // GET: News/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var news = await _context.News
            .FirstOrDefaultAsync(m => m.NewsId == id);
        if (news == null)
        {
            return NotFound();
        }

        return View(news);
    }

    // POST: News/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var news = await _context.News.FindAsync(id);

        if (news.ImageURL != null)
        {
            //delete image from wwwroot/image
            var imagePath = Path.Combine(_hostEnvironment.WebRootPath, "image", news.ImageURL);
            if (System.IO.File.Exists(imagePath))
                System.IO.File.Delete(imagePath);
        }


        _context.News.Remove(news);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool NewsExists(int id)
    {
        return _context.News.Any(e => e.NewsId == id);
    }


}
