using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SystemBase;

namespace Core.CM
{
    public class Pages
    {
        public int? PageID { get; set; }
        public int? ParentID { get; set; }
        public string TitleEN { get; set; }
        public string TitleKA { get; set; }
        public string TitleRU { get; set; }
        public string Title
        {
            get
            {
                if (Thread.CurrentThread.CurrentUICulture.Name == "ka-GE")
                {
                    return TitleKA;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == "ru-RU")
                {
                    return TitleRU;
                }
                return TitleEN;
            }
        }        
        public string DescriptionKA { get; set; }
        public string DescriptionRU { get; set; }
        public string DescriptionEN { get; set; }
        public string Description
        {
            get
            {
                if (Thread.CurrentThread.CurrentUICulture.Name == "ka-GE")
                {
                    return DescriptionKA;
                }
                if (Thread.CurrentThread.CurrentUICulture.Name == "ru-RU")
                {
                    return DescriptionRU;
                }
                return DescriptionEN;
            }
        }
        public int? TemplateID { get; set; }
        public string URL { get; set; }
        public string Note { get; set; }
        public int? GalleryID { get; set; }
        public bool? IsVisible { get; set; }
    }
    public class PagesRepository : ObjectBase
    {
        public int? ID { get; set; }
        public List<Pages> ListPages()
        {
            return TryToReturn(string.Format("Core.CM.PagesRepository.ListPages()"), () =>
            {
                using (var db = DB.DBCon.GetCMDataContext())
                {
                    return db.fn_List_Pages(null).Select(s => new Pages
                    {
                        PageID=s.PageID,
                        ParentID=s.ParentID,
                        TitleEN = s.TitleEN,
                        TitleKA = s.TitleKA,
                        TitleRU = s.TitleRU,
                        DescriptionEN = s.DescriptionEN,
                        DescriptionKA = s.DescriptionKA,
                        DescriptionRU = s.DescriptionRU,
                        TemplateID=s.TemplateID,
                        URL=s.URL,
                        Note=s.Note,	
                        GalleryID=s.GalleryID,	
                        IsVisible=s.IsVisible
                    }).ToList();
                }
            });
        }
        public void SP_Pages(int? iud, int? PageID = null, int? ParentID = null, string TitleEN = null, string TitleKA = null, string TitleRU = null, 
                            string DescriptionEN = null, string DescriptionKA = null, string DescriptionRU = null, int? TemplateID = null,
                            string URL = null, string Note = null, int? GalleryID = null, bool? IsVisible = null)
        {
            TryExecute(string.Format("SP_Pages(iud = {0}, PageID = {1}, ParentID = {2}, TitleEN = {3}, TitleKA = {4}, TitleRU = {5}, DescriptionEN = {6}, DescriptionKA = {7}, DescriptionRU = {8}, TemplateID = {9}, URL = {10}, Note = {11}, GalleryID = {12}, IsVisible = {13})",
                iud, PageID, ParentID, TitleEN, TitleKA, TitleRU, DescriptionEN, DescriptionKA, DescriptionRU, TemplateID, URL, Note, GalleryID, IsVisible), () =>
            {
                using (var db = DB.DBCon.GetCMDataContext())
                {
                    int? NewID = PageID;
                    db.sp_Pages(iud, ref NewID, ParentID, TitleEN, TitleKA, TitleRU, DescriptionEN, DescriptionKA, DescriptionRU, TemplateID, URL, Note, GalleryID, IsVisible);
                    this.ID = NewID;
                }
            });
        }


    }
    


}
