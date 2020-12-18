using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Exec02.FrontEnd.Application.ViewModels
{
	public class HotNewsVM
	{
		[Display(Name ="編號")]
		public int Id { get;internal set; }
		[Display(Name =	"標題")]
		
		public string Title { get; internal set; }
		[Display(Name ="更新時間")]
		public DateTime PublishTime { get; internal set; }
	}
}