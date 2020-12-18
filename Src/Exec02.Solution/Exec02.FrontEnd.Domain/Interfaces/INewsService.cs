using System.Collections.Generic;

namespace Exec02.FrontEnd.Domain.News
{
    public interface INewsService
    {
        IEnumerable<NewsEntity> GetHotNews(int rows);
        IEnumerable<NewsEntity> GetNewsList();
        NewsEntity GetNews(int id);
        
    }
}