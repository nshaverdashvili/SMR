using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SystemBase;

namespace Core.Tools
{
    public class Dictionary
    {
        public int? DictionaryID { get; set; }
        public int? DictionaryCode { get; set; }
        public string CaptionEN { get; set; }
        public string CaptionKA { get; set; }
        public string CaptionRU { get; set; }
        public string Caption
        {
            get
            {
                if (Thread.CurrentThread.CurrentUICulture.Name == "ka-GE")
                {
                    return CaptionKA;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == "ru-RU")
                {
                    return CaptionRU;
                }
                return CaptionEN;
            }
        }
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

        public List<Dictionary> ListDictionary(int? Lvl, int? Code, bool? IsVisible = null) //
        {
            return TryToReturn(string.Format("Core.Tools.DictionariesRepository.ListDictionary()"), () =>
            {
                using (var db = DB.DBCon.GetToolsDataContext())
                {
                    return db.fn_List_Dictionaries(Lvl, Code, IsVisible).Select(s => new Dictionary
                    {
                        DictionaryID = s.DictionaryID,
                        CaptionEN = s.CaptionEN,
                        CaptionKA = s.CaptionKA,
                        CaptionRU = s.CaptionRU,
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

        public void SP_Dictionary(int? iud, int? DictionaryID = null, string CaptionEN = null,  string CaptionKA = null, string CaptionRU = null, string Caption1 = null, int? CodeVal = null, int? ParentID = null,
                                  short? Level = null, string Hierarchy = null, string StringCode = null, int? DictionaryCode = null, bool? DefVal = null,
                                  bool? Visible = null, int? SortVal = null)
        {
            TryExecute(string.Format("SP_Dictionary(iud = {0}, DictionaryID = {1}, CaptionEN = {2}, CaptionKA = {3}, CaptionRU = {4}, Caption1 = {5}, CodeVal = {6}, ParentID = {7}, Level = {8}, Hierarchy = {9}, StringCode = {10}, DictionaryCode = {11}, DefVal = {12}, Visible = {13}, SortVal = {14})", iud, DictionaryID,
                CaptionEN, CaptionKA, CaptionRU, Caption1, CodeVal, ParentID, Level, Hierarchy, StringCode, 
                DictionaryCode, DefVal, Visible, SortVal), () =>
            {
                using (var db = DB.DBCon.GetToolsDataContext())
                {
                    int? NewID = DictionaryID;
                    db.sp_Dictionaries(iud, ref NewID, CaptionEN, CaptionKA, CaptionRU, Caption1, CodeVal, ParentID, Level, Hierarchy, StringCode, DictionaryCode, DefVal, Visible, SortVal);
                    this.ID = NewID;
                }
            });
        }
    }
}
