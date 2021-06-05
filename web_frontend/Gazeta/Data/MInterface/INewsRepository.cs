using Gazeta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gazeta.Data.MInterface
{
    //public interface INewsRepository
    //{
    //    // News NewsDetail(int? id);
    //    // IEnumerable<News> GetNewsByCompany(string companyName);
    //    IEnumerable<News> LatestNews();
    //    // IEnumerable<News> GetNewsByGener(string storyType);
    //    IEnumerable<News> GetNewsMostLiked();
    //    // void CreateNews(News news);
    //    bool LikeNews(int? id);
    //    void EditNews(News news);
    //    IEnumerable<News> Search(string searchArg);
    //    void PostNews(News news);
    //    void RegisterCompany(Company company);
    //    News NewsDetail(int? id);
    //    News GetNews(int? id);
    //    Company CompanyProfile(string companyEmail);
    //    IEnumerable<News> GetNewsByCompany(string companyEmail);
    //    IEnumerable<News> LatestNews(IEnumerable<News> filteredNews);
    //    IEnumerable<News> GetNewsByGenre(string storyType);
    //    IEnumerable<News> MostLikedNews(IEnumerable<News> filteredNews);
    //    IEnumerable<Subscription> GetSubscribersList(string companyEmail);
    //    News Save(News oNews);
    //    News GetSavedNews();

    //}
    public interface INewsRepository
    {
        // News NewsDetail(int? id);
        // IEnumerable<News> GetNewsByCompany(string companyName);
        IEnumerable<News> LatestNews();
        // IEnumerable<News> GetNewsByGener(string storyType);
        IEnumerable<News> GetNewsMostLiked();
        // void CreateNews(News news);
        bool LikeNews(int? id);
        void EditNews(News news);
        IEnumerable<News> Search(string searchArg);
        void PostNews(News news);
        void RegisterCompany(Company company);
        News NewsDetail(int? id);
        Company CompanyProfile(string companyEmail);
        News GetNews(int? id);
        IEnumerable<News> GetNewsByCompany(string companyEmail);
        IEnumerable<News> LatestNews(IEnumerable<News> filteredNews);
        IEnumerable<News> GetNewsByGenre(string storyType);
        IEnumerable<News> GetNewsByGenre(string storyType, IEnumerable<News> filteredNews);

        IEnumerable<News> MostLikedNews(IEnumerable<News> filteredNews);
        IEnumerable<Subscription> GetSubscribersList(string companyEmail);
        News Save(News oNews);
        News GetSavedNews();

    }
}
