using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemBase;

namespace Core.Files
{
    public class Files
    {
        public int FileID { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public int? TypeID { get; set; }
    }
    public class FilesRepository : ObjectBase
    {

    }
}
