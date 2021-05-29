using Gazeta.Data.MInterface;
using Gazeta.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gazeta.Data.MClass
{
    public class NewsRepository : INewsRepository
    {
        public GazetaWebContext Context { get; }
        public NewsRepository(GazetaWebContext context)
        {
            Context = context;
        }

        

        public  void CreateNews(News news)
        {
            Context.Add(news);
            Context.SaveChanges();//asyncronous proplem might occur be back later
          
        }

        public IEnumerable<News> GetNewsByCompany(string companyName)
        {
            var NewsByCompany = (from news in Context.News
                                where news.Company == companyName
                                select news).ToList();

            return NewsByCompany;
        }

        public IEnumerable<News> GetNewsByGener(string storyType)
        {
            throw new NotImplementedException();
        }

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

        public News NewsDetail(int? id)
        {
            var news = Context.News.FirstOrDefault(n => n.Id == id);

            return news;
        }
    }
}
