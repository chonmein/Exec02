using System.Collections.Generic;
using Exec02.FrontEnd.Domain.News;

namespace Exec02.FrontEnd.Domain.Interfaces
{
	public interface INewsRepository
	{
		IEnumerable<NewsEntity> GetHotNews(int rows);
		IEnumerable<NewsEntity> GetNewsList();
		NewsEntity GetNews(int id);
	}
}