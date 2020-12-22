using System.Collections.Generic;
using Exec02.FrontEnd.Domain.Interfaces;

namespace Exec02.FrontEnd.Domain.News
{
    public class NewsService : INewsService
    {
        private readonly INewsRepository _newsRepository;

        public NewsService(INewsRepository newsRepository)
        {
            _newsRepository = newsRepository;
        }

        public IEnumerable<NewsEntity> GetHotNews(int rows)
        {
            return _newsRepository.GetHotNews(rows);
        }

        public NewsEntity GetNews(int id)
        {
            var News = _newsRepository.GetNews(id);
            if (News != null)
                return News;
            return new NewsEntity();
        }

        public IEnumerable<NewsEntity> GetNewsList()
        {
            return _newsRepository.GetNewsList();
        }
    }
}