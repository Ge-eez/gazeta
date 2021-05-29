using Gazeta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gazeta.Data.MInterface
{
    public interface INewsRepository
    {
        News NewsDetail(int? id);
        IEnumerable<News> GetNewsByCompany(string companyName);
        IEnumerable<News> LatestNews();
        IEnumerable<News> GetNewsByGener(string storyType);
        void CreateNews(News news);
    }
}
