using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exec02.FrontEnd.Domain.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exec02.FrontEnd.Domain.Interfaces;
using Exec02.FrontEnd.Infra.Data.Repositories;
using Exec02.FrontEnd.Infra.Data.EFModels;
using Moq;

namespace 消息測試
{
    [TestClass()]
    public class NewsServiceTest
    {

        [TestMethod()]
        public void 最新消息_返回筆數與指定筆數相同或為大於0的正整數()
        {
            var mock = new Mock<INewsRepository>();
            NewsService service = new NewsService(mock.Object);
            int TotalRow;
            for (int rows = 1; rows <= 100; rows++)
            {
                TotalRow = service.GetHotNews(rows).Count();
                if(TotalRow < 1)
                {
                    Assert.Fail("返回筆數不正確，為 {0} 筆", TotalRow);
                }
            }
        }

        [TestMethod()]
        public void 最新消息_要求筆數為非正數時返回空集合()
        {
            Assert.Fail();
        }
    }
}