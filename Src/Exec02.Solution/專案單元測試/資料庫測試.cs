using Exec02.FrontEnd.Domain.Interfaces;
using Exec02.FrontEnd.Domain.News;
using Exec02.FrontEnd.Infra.Data.EFModels;
using Exec02.FrontEnd.Infra.Data.Repositories;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 專案單元測試
{
    [TestFixture()]
    public class NewsService測試
    {
        [Test()]
        [TestCase(1)]
        [TestCase(0)]
        [TestCase(-1)]
        public void 取得最新消息_輸入不為正數時不是Null(int count)
        {
            var mockNewsRepository = new Mock<INewsRepository>();
            NewsService newsService = new NewsService(mockNewsRepository.Object);
            var result = newsService.GetHotNews(count);
            Assert.IsNotNull(result);
        }

        [Test()]
        public void 取得消息列表_沒有返回Null()
        {
            var mockNewsRepository = new Mock<INewsRepository>();
            NewsService newsService = new NewsService(mockNewsRepository.Object);
            var result = newsService.GetNewsList();
            Assert.IsNotNull(result);
        }

        [Test()]
        [TestCase(1)]
        [TestCase(10)]
        [TestCase(100)]
        public void 取得詳細消息_沒有返回Null(int id)
        {
            var mockNewsRepository = new Mock<INewsRepository>();
            NewsService newsService = new NewsService(mockNewsRepository.Object);
            newsService.GetNews(id);
        }
    }
}
