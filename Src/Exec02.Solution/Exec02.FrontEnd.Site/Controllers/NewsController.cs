using Exec02.FrontEnd.Application.News;
using Exec02.FrontEnd.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exec02.FrontEnd.Site.Controllers
{
    public class NewsController : Controller
    {
        private readonly IHotNewsApi _hotNewsApi;
        private readonly INewsApi _newsApi;

        public NewsController(IHotNewsApi hotNewsApi, INewsApi newsApi)
        {
            _hotNewsApi = hotNewsApi;
            _newsApi = newsApi;
        }

        // GET: News
        public ActionResult Index()
        {
            IEnumerable<NewsIndexVM> model = _newsApi.GetNewsList();
            return View(model);
        }

        public ActionResult HotNews()
        {
            int maxRows = 5;
            IEnumerable<HotNewsVM> model = _hotNewsApi.GetHotNews(maxRows);

            return PartialView(model);
        }

        public ActionResult DetailNews(int id)
        {
            NewsVM model = _newsApi.GetNews(id);
            return View(model);
        }        
    }
}