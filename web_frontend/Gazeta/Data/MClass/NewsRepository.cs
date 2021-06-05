using Gazeta.Data.MInterface;
using Gazeta.Data;
using Gazeta.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// using ExceptionHandling;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Gazeta.Data.MClass
{

    //public class NewsRepository : INewsRepository
    //{
    //    public event EventHandler NewPostCreated;
    //    public ApplicationDbContext Context { get; }


    //    public NewsRepository()
    //    {

    //    }

    //    public NewsRepository(ApplicationDbContext context)
    //    {
    //        Context = context;
    //        // this._hostEnvironment = hostEnvironment;
    //    }

    //    public virtual void OnNewPostCreated()
    //    {
    //        if(NewPostCreated != null)
    //        {
    //            NewPostCreated(this, EventArgs.Empty);
    //        }
    //    }

    //    // Post news: Add new post to the table named news
    //    public
    //    async void PostNews(News news)
    //    {
    //        try
    //        {                
    //            Context.Add(news);
    //            Context.SaveChanges();
    //            OnNewPostCreated();
    //        }
    //        catch (Exception )
    //        {
    //            // throw new CustomException("Couldn't save the changes", e);
    //            throw;
    //        }
    //    }

    //    public async void RegisterCompany(Company company)
    //    {
    //        try
    //        {                
    //            Context.Add(company);
    //            await Context.SaveChangesAsync();
    //            OnNewPostCreated();
    //        }
    //        catch (Exception )
    //        {
    //            // throw new CustomException("Couldn't save the changes", e);
    //            throw;
    //        }
    //    }

    //    //query news from based on company name return collection of news
    //    public IEnumerable<News> GetNewsByCompany(string CompanyEmail)
    //    {
    //        var NewsByCompany = (from news in Context.News
    //                            where news.CompanyEmail == CompanyEmail
    //                            select news).ToList();

    //        return NewsByCompany;
    //    }

    //    public IEnumerable<News> LatestNews(IEnumerable<News> filteredNews)
    //    {
    //        var LatestNews = (from news in filteredNews
    //                            orderby news.PublishDate descending
    //                            select news).ToList();
    //        List<News> Latest = new List<News>(); 
    //        for (int i = 0; i < LatestNews.Count; i++)
    //        {
    //            Latest.Add(LatestNews[i]);
    //        }
    //        return Latest;
    //    }

    //    public IEnumerable<Subscription> GetSubscribersList(string companyName)
    //    {
    //        var CompanySubscribed = (from subscribe in Context.Subscriptions
    //                          where subscribe.CompanyName == companyName
    //                          select subscribe).ToList();

    //        return CompanySubscribed;
    //    }

    //    public IEnumerable<News> GetNewsByGenre(string storyType)
    //    {
    //        var NewsByGener = (from news in Context.News
    //                             where news.Genre == storyType
    //                             select news).ToList();

    //        return NewsByGener;
    //    }

    //    //details of a news with Id value passed in as argument
    //    public News NewsDetail(int? id)
    //    {
    //        var news = Context.News.FirstOrDefault(n => n.NewsId == id);
    //        LikeNews(id);
    //        return news;
    //    }
    //    public News GetNews(int? id)
    //    {
    //        var news = Context.News.FirstOrDefault(n => n.NewsId == id);

    //        return news;
    //    }

    //    public Company CompanyProfile(String CompanyEmail)
    //    {
    //        var company = Context.Companies.FirstOrDefault(n => n.CompanyEmail == CompanyEmail);
    //        return company;
    //    }

    //    //apply like action to increment the Likes property of News
    //    public bool LikeNews(int? id)
    //    {
    //        try
    //        {
    //            var news = Context.News.FirstOrDefault(n => n.NewsId == id);
    //            news.Likes += 1;

    //            Context.Update(news);
    //            Context.SaveChanges();
    //        }
    //        catch (DbUpdateConcurrencyException )
    //        {

    //            // throw new CustomException("Couldn't add likes", e);
    //            throw;
    //        }
    //        return true;
    //    }

    //    //query news on the number of Likes it has
    //    public IEnumerable<News> MostLikedNews(IEnumerable<News> filteredNews)
    //    {
    //        var MostLiked = (from news in filteredNews
    //                        orderby news.Likes descending
    //                        select news).ToList();
    //        List<News> Liked = new List<News>();
    //        for (int i = 0; i < MostLiked.Count; i++)
    //        {
    //            Liked.Add(MostLiked[i]);
    //        }
    //        return Liked;

    //    }

    //    public async void EditNews(News news)
    //    {
    //        Context.Update(news);
    //        await Context.SaveChangesAsync();
    //    }

    //    public News Save(News oNews)
    //    {
    //        Context.News.Add(oNews);
    //        Context.SaveChanges();
    //        return oNews;
    //    }

    //    public News GetSavedNews()
    //    {
    //        return Context.News.SingleOrDefault();
    //    }


    //    // public virtual void OnNewPostCreated()
    //    // {
    //    //     if(NewPostCreated != null)
    //    //     {
    //    //         NewPostCreated(this, EventArgs.Empty);
    //    //     }
    //    // }

    //    // public  void CreateNews(News news)
    //    // {
    //    //     try
    //    //     {
    //    //         Context.Add(news);
    //    //         Context.SaveChanges();//asyncronous proplem might occur be back later
    //    //         OnNewPostCreated();
    //    //     }
    //    //     catch (Exception)
    //    //     {

    //    //         throw;
    //    //     }
    //    // }

    //    //query news from based on company name return collection of news
    //    // public IEnumerable<News> GetNewsByCompany(string companyName)
    //    // {
    //    //     var NewsByCompany = (from news in Context.News
    //    //                         where news.Company == companyName
    //    //                         select news).ToList();

    //    //     return NewsByCompany;
    //    // }

    //    //query news from based on Gener type return collection of news
    //    // public IEnumerable<News> GetNewsByGener(string storyType)
    //    // {
    //    //     var NewsByGener = (from news in Context.News
    //    //                          where news.Gener == storyType
    //    //                          select news).ToList();

    //    //     return NewsByGener;
    //    // }

    //    //return collection of latest news
    //    public IEnumerable<News> LatestNews()
    //    {
    //        var LatestNews = (from news in Context.News
    //                            orderby news.PublishDate descending
    //                            select news).ToList();
    //        List<News> Latest = new List<News>(); 
    //        for (int i = 0; i < LatestNews.Count; i++)
    //        {
    //            Latest.Add(LatestNews[i]);
    //        }
    //        return Latest;
    //    }

    //    //details of a news with Id value passed in as argument
    //    // public News NewsDetail(int? id)
    //    // {
    //    //     var news = Context.News.FirstOrDefault(n => n.Id == id);

    //    //     return news;
    //    // }

    //    //apply like action to increment the Likes property of News
    //    // public bool LikeNews(int? id)
    //    // {
    //    //     try
    //    //     {
    //    //         var news = Context.News.FirstOrDefault(n => n.Id == id);
    //    //         news.Likes += 1;

    //    //         Context.Update(news);
    //    //         Context.SaveChanges();
    //    //     }
    //    //     catch (DbUpdateConcurrencyException)
    //    //     {

    //    //         throw;
    //    //     }
    //    //     return true;
    //    // }

    //    //query news on the number of Likes it has
    //    public IEnumerable<News> GetNewsMostLiked()
    //    {
    //        var MostLiked = (from news in Context.News
    //                        orderby news.Likes descending
    //                        select news).ToList();
    //        List<News> Liked = new List<News>();
    //        for (int i = 0; i < MostLiked.Count; i++)
    //        {
    //            Liked.Add(MostLiked[i]);
    //        }
    //        return Liked;

    //    }

    //    // public void EditNews(News news)
    //    // {
    //    //     Context.Update(news);
    //    //     Context.SaveChangesAsync();
    //    // }

    //    public IEnumerable<News> Search(string searchArg)
    //    {
    //        var result = from news in Context.News
    //                     where news.Headline.Contains(searchArg)
    //                     select news;
    //        return result;
    //    }

    //}
    public class NewsRepository : INewsRepository
    {
        public event EventHandler NewPostCreated;
        public ApplicationDbContext Context { get; }


        public NewsRepository()
        {

        }

        public NewsRepository(ApplicationDbContext context)
        {
            Context = context;
            // this._hostEnvironment = hostEnvironment;
        }
        public News GetNews(int? id)
        {
            var news = Context.News.FirstOrDefault(n => n.NewsId == id);

            return news;
        }
        public virtual void OnNewPostCreated()
        {
            if (NewPostCreated != null)
            {
                NewPostCreated(this, EventArgs.Empty);
            }
        }

        // Post news: Add new post to the table named news
        public
        void PostNews(News news)
        {
            try
            {
                Context.Add(news);
                Context.SaveChanges();
                OnNewPostCreated();
            }
            catch (Exception)
            {
                // throw new CustomException("Couldn't save the changes", e);
                throw;
            }
        }

        public async void RegisterCompany(Company company)
        {
            try
            {
                Context.Add(company);
                await Context.SaveChangesAsync();
                OnNewPostCreated();
            }
            catch (Exception)
            {
                // throw new CustomException("Couldn't save the changes", e);
                throw;
            }
        }

        //query news from based on company name return collection of news
        public IEnumerable<News> GetNewsByCompany(string CompanyEmail)
        {
            var NewsByCompany = (from news in Context.News
                                 where news.CompanyEmail == CompanyEmail
                                 select news).ToList();

            return NewsByCompany;
        }

        public IEnumerable<News> LatestNews(IEnumerable<News> filteredNews)
        {
            var LatestNews = (from news in filteredNews
                              orderby news.PublishDate descending
                              select news).ToList();
            List<News> Latest = new List<News>();
            for (int i = 0; i < LatestNews.Count; i++)
            {
                Latest.Add(LatestNews[i]);
            }
            return Latest;
        }

        public IEnumerable<Subscription> GetSubscribersList(string companyName)
        {
            var CompanySubscribed = (from subscribe in Context.Subscriptions
                                     where subscribe.CompanyName == companyName
                                     select subscribe).ToList();

            return CompanySubscribed;
        }

        public IEnumerable<News> GetNewsByGenre(string storyType, IEnumerable<News> filteredNews)
        {
            var NewsByGenre = (from news in filteredNews
                               where news.Genre == storyType
                               select news).ToList();

            return NewsByGenre;
        }
        public IEnumerable<News> GetNewsByGenre(string storyType)
        {
            var NewsByGenre = (from news in Context.News
                               where news.Genre == storyType
                               select news).ToList();

            return NewsByGenre;
        }

        //details of a news with Id value passed in as argument
        public News NewsDetail(int? id)
        {
            var news = Context.News.FirstOrDefault(n => n.NewsId == id);
            LikeNews(id);
            return news;
        }

        public Company CompanyProfile(String CompanyEmail)
        {
            var company = Context.Companies.FirstOrDefault(n => n.CompanyName == CompanyEmail);
            return company;
        }

        //apply like action to increment the Likes property of News
        public bool LikeNews(int? id)
        {
            try
            {
                var news = Context.News.FirstOrDefault(n => n.NewsId == id);
                news.Likes += 1;

                Context.Update(news);
                Context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {

                // throw new CustomException("Couldn't add likes", e);
                throw;
            }
            return true;
        }

        //query news on the number of Likes it has
        public IEnumerable<News> MostLikedNews(IEnumerable<News> filteredNews)
        {
            var MostLiked = (from news in filteredNews
                             orderby news.Likes descending
                             select news).ToList();
            List<News> Liked = new List<News>();
            for (int i = 0; i < MostLiked.Count; i++)
            {
                Liked.Add(MostLiked[i]);
            }
            return Liked;

        }

        public async void EditNews(News news)
        {
            Context.Update(news);
            await Context.SaveChangesAsync();
        }

        public News Save(News oNews)
        {
            Context.News.Add(oNews);
            Context.SaveChanges();
            return oNews;
        }

        public News GetSavedNews()
        {
            return Context.News.SingleOrDefault();
        }


        // public virtual void OnNewPostCreated()
        // {
        //     if(NewPostCreated != null)
        //     {
        //         NewPostCreated(this, EventArgs.Empty);
        //     }
        // }

        // public  void CreateNews(News news)
        // {
        //     try
        //     {
        //         Context.Add(news);
        //         Context.SaveChanges();//asyncronous proplem might occur be back later
        //         OnNewPostCreated();
        //     }
        //     catch (Exception)
        //     {

        //         throw;
        //     }
        // }

        //query news from based on company name return collection of news
        // public IEnumerable<News> GetNewsByCompany(string companyName)
        // {
        //     var NewsByCompany = (from news in Context.News
        //                         where news.Company == companyName
        //                         select news).ToList();

        //     return NewsByCompany;
        // }

        //query news from based on Gener type return collection of news
        // public IEnumerable<News> GetNewsByGener(string storyType)
        // {
        //     var NewsByGener = (from news in Context.News
        //                          where news.Gener == storyType
        //                          select news).ToList();

        //     return NewsByGener;
        // }

        //return collection of latest news
        public IEnumerable<News> LatestNews()
        {
            var LatestNews = (from news in Context.News
                              orderby news.PublishDate descending
                              select news).ToList();
            List<News> Latest = new List<News>();
            for (int i = 0; i < LatestNews.Count; i++)
            {
                Latest.Add(LatestNews[i]);
            }
            return Latest;
        }

        //details of a news with Id value passed in as argument
        // public News NewsDetail(int? id)
        // {
        //     var news = Context.News.FirstOrDefault(n => n.Id == id);

        //     return news;
        // }

        //apply like action to increment the Likes property of News
        // public bool LikeNews(int? id)
        // {
        //     try
        //     {
        //         var news = Context.News.FirstOrDefault(n => n.Id == id);
        //         news.Likes += 1;

        //         Context.Update(news);
        //         Context.SaveChanges();
        //     }
        //     catch (DbUpdateConcurrencyException)
        //     {

        //         throw;
        //     }
        //     return true;
        // }

        //query news on the number of Likes it has
        public IEnumerable<News> GetNewsMostLiked()
        {
            var MostLiked = (from news in Context.News
                             orderby news.Likes descending
                             select news).ToList();
            List<News> Liked = new List<News>();
            for (int i = 0; i < MostLiked.Count; i++)
            {
                Liked.Add(MostLiked[i]);
            }
            return Liked;

        }

        // public void EditNews(News news)
        // {
        //     Context.Update(news);
        //     Context.SaveChangesAsync();
        // }

        public IEnumerable<News> Search(string searchArg)
        {
            var result = from news in Context.News
                         where news.Headline.Contains(searchArg)
                         select news;
            return result;
        }

    }

}
