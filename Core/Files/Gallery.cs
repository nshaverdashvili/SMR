using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemBase;

namespace Core.Files
{
    public class Gallery
    {
        public int RecordID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? LangID { get; set; }
    }
    public class GalleryRepository : ObjectBase
    {

    }
    
}
