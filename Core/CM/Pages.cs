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
        public int? ID { get; set; }
        public List<Pages> ListPages(int PageID)
        {
            return TryToReturn(string.Format("Core.CM.PagesRepository.ListPages(PageID = {0})", PageID), () =>
            {
                using (var db = DB.DBCon.GetCMDataContext())
                {
                    return db.fn_List_Pages(PageID).Select(s => new Pages
                    {
                        ParentID=s.ParentID,
                        Title=s.Title,
                        Description=s.Description,
                        TemplateID=s.TemplateID,
                        URL=s.URL,
                        Note=s.Note,	
                        GalleryID=s.GalleryID,	
                        LangID=s.LangID,
                        IsVisible=s.IsVisible
                    }).ToList();
                }
            });
        }
        public void SP_Pages(int? iud, int? PageID = null, int? ParentID = null, string Title = null, string Description = null, int? TemplateID=null,
                            string URL = null, string Note = null, int? GalleryID = null, int? LangID = null, bool? IsVisible = null)
        {
            TryExecute(string.Format(@"Core.CM.PagesRepository(iud = {0}, PageID = {1},ParentID = {2},Title = {3}, Description = {4},
            TemplateID = {5}, URL ={6}, Note = {7}, GalleryID = {8}, LangID = {9}, IsVisible = {10})", iud, PageID, ParentID, Title, 
            Description, TemplateID, URL, Note, GalleryID, LangID, IsVisible), () =>
            {
                using (var db = DB.DBCon.GetCMDataContext())
                {
                    int? NewID = PageID;
                    db.sp_Pages(iud, ref NewID, ParentID, Title, Description, TemplateID, URL, Note, GalleryID, LangID, IsVisible);
                    this.ID = NewID;
                }
            });
        }


    }
    


}
