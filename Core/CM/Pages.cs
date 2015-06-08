using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemBase;

namespace Core.CM
{
    public class Pages
    {
        public int PageID { get; set; }
        public int? ParentID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? TemplateID { get; set; }
        public string URL { get; set; }
        public string Note { get; set; }
        public int? GalleryID { get; set; }
        public int? LangID { get; set; }
        public bool? IsVisible { get; set; }
    }
    public class PagesRepository : ObjectBase
    {

    }
    


}
