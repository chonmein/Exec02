using Exec02.FrontEnd.Application.ViewModels;
using Exec02.FrontEnd.Domain.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec02.FrontEnd.Application.News
{
    public class NewsApi : INewsApi
    {
        private readonly INewsService _newsService;
        public NewsApi(INewsService newsService)
        {
            _newsService = newsService;
        }

        public NewsVM GetNews(int id)
        {
            return _newsService.GetNews(id).ToNewsVM();
        }

        public IEnumerable<NewsVM> GetNewsList()
        {
            var newsList = _newsService.GetNewsList();
            if (newsList == null)
                return Enumerable.Empty<NewsVM>();
            return newsList.Select(news =>news.ToNewsVM());
        }
    }
}
