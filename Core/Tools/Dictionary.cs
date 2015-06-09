using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemBase;

namespace Core.Tools
{
    public class Dictionary
    {
        public int? ID { get; set; }
        public int? DictionaryCode { get; set; }
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
        public int? ID { get; set; }

        public List<Dictionary> ListDictionary(int? Lvl, int? Code, bool? IsVisible=null)
        {
            return TryToReturn(string.Format("Core.Tools.DictionariesRepository.ListDictionary(Lvl = {0}, Code = {1}, IsVisible = {2})", Lvl, Code, IsVisible), () =>
            {
                using (var db = DB.DBCon.GetToolsDataContext())
                {
                    return db.fn_List_Dictionaries(Lvl, Code, IsVisible).Select(s => new Dictionary { 
                        ID = s.DictionaryID,
                        Caption=s.Caption,
                        Caption1=s.Caption1,
                        ParentID=s.ParentID,
                        StringCode=s.StringCode,
                        CodeVal=s.CodeVal,
                        Visible=s.Visible,
                        SortVal=s.SortVal,
                        DictionaryCode=s.DictionaryCode                    
                    }).ToList();

                }
            });
        }

        public void SP_Dictionary(int? iud, int? DictionaryID = null, string Caption = null, string Caption1 = null, int? CodeVal = null, int? ParentID = null,
                                  short? Level = null, string Hierarchy = null, string StringCode = null, int? DictionaryCode = null, bool? DefVal = null,
                                  bool? Visible = null, int? SortVal = null)
        {
            TryExecute(string.Format(@"Core.Tools.DictionariesRepository(iud = {0}, DictionaryID = {1},Caption= {2},Caption1= {3},CodeVal= {4},ParentID= {5},Level= {6},
            Hierarchy= {7},StringCode= {8},DictionaryCode  = {9}, DefVal= {10}, Visible= {11},SortVal= {12} )", iud, DictionaryID, Caption, Caption1, CodeVal, ParentID,
            Level, Hierarchy, StringCode, DictionaryCode, DefVal, Visible, SortVal), () =>
            {
                using (var db = DB.DBCon.GetToolsDataContext())
                {
                    int? NewID = DictionaryID;
                    db.sp_Dictionaries(iud, ref NewID, Caption, Caption1, CodeVal, ParentID, Level, Hierarchy, StringCode, DictionaryCode, DefVal, Visible, SortVal);
                    this.ID = NewID;
                }
            });
        }
    }
}
