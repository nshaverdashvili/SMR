using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemBase;

namespace Core.CM
{
    public class News
    {
        public int NewsID { get; set; }
        public DateTime? NewsDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string FullText { get; set; }
        public int? LangID { get; set; }
        public int? CategoryID { get; set; }
        public int? SortVal { get; set; }
        public bool? IsVisible { get; set; }
        public string VideoURL { get; set; }
        public int? GalleryID { get; set; }
    }
    public class NewsRepository : ObjectBase
    {

    }

}
