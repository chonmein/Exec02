using Exec02.FrontEnd.Application.ViewModels;
using Exec02.FrontEnd.Domain.News;

namespace Exec02.FrontEnd.Application.News
{
	internal static class NewsEntityAssembler
	{
		public static HotNewsVM ToHotNewsVM(this NewsEntity entity)
		{
			return new HotNewsVM
			{
				Id=entity.Id,
				Title = entity.Title,
				PublishTime = entity.PublishTime
			};
		}
		public static NewsVM ToNewsVM(this NewsEntity entity)
        {
			return new NewsVM()
			{
				Id = entity.Id,
				Content = entity.Content,
				Title = entity.Title,
				CreatedTime = entity.CreatedTime,
				PublishTime = entity.PublishTime,
				LastModifiedTime = entity.LastModifiedTime,
			};
        }

		public static NewsIndexVM ToNewsIndexVM(this NewsEntity entity)
        {
			return new NewsIndexVM
			{
				Id = entity.Id,
				Title = entity.Title,
				PublishTime = entity.PublishTime
			};
		}
	}
}