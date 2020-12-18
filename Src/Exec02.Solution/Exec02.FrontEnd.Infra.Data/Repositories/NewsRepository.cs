using System;
using System.Collections.Generic;
using System.Linq;
using Exec02.FrontEnd.Domain.Interfaces;
using Exec02.FrontEnd.Domain.News;
using Exec02.FrontEnd.Infra.Data.EFModels;

namespace Exec02.FrontEnd.Infra.Data.Repositories
{
	public class NewsRepository : INewsRepository
	{
		private readonly ErpDbContext _context;

		public NewsRepository(ErpDbContext context)
		{
			_context = context;
		}

		public IEnumerable<NewsEntity> GetHotNews(int rows)
		{
			IEnumerable<News> data = _context.News
				.OrderByDescending(news => news.PublishTime)
				.Take(rows);

			return data.Select(efModel => efModel.ToEntity());
		}

		public NewsEntity GetNews(int id)
        {
			News data = _context.News.Find(id);

			return data.ToEntity();
        }

        public IEnumerable<NewsEntity> GetNewsList()
        {
			IEnumerable<News> data = _context.News
				.OrderByDescending(news => news.PublishTime);

			return data.Select(efModel=>efModel.ToEntity());
        }
    }
}