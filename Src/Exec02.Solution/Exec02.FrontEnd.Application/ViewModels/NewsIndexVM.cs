using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec02.FrontEnd.Application.ViewModels
{
    public class NewsIndexVM
    {
        [Display(Name ="編號")]
        public int Id { get; set; }
        [Display(Name ="標題")]
        public string Title { get; set; }
        [Display(Name = "發佈時間")]
        public DateTime PublishTime { get; set; }
        
    }
}
