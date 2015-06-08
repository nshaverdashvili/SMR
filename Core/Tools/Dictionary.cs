using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemBase;

namespace Core.Tools
{
    public class Dictionaries
    {
        public int DictionaryID { get; set; }
        public string Caption { get; set; }
        public string Caption1 { get; set; }
        public int? CodeVal { get; set; }
        public int? ParentID { get; set; }
        public short? Level { get; set; } 
        public string HierarchyCode { get; set; }
        public string StringCode { get; set; }
        public bool? DefVal { get; set; }
        public bool? Visible { get; set; }
        public int? SortVal { get; set; }
    }
    public class DictionariesRepository : ObjectBase
    {

    }
}
