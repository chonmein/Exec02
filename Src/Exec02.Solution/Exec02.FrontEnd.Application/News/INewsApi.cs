using Exec02.FrontEnd.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec02.FrontEnd.Application.News
{
    public interface INewsApi
    {
        IEnumerable<NewsVM> GetNewsList();
        NewsVM GetNews(int id);
    }
}
