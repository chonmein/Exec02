using Exec02.FrontEnd.Application.ViewModels;
using System.Collections.Generic;

namespace Exec02.FrontEnd.Application.News
{
    public interface IHotNewsApi
    {
        IEnumerable<HotNewsVM> GetHotNews(int maxRows);
    }
}