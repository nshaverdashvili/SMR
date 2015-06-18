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
        public int? NewsID { get; set; }
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
        public int? ID { get; set; }
        public List<News> ListNews()
        {
            return TryToReturn(string.Format("Core.CM.NewsRepository.ListNews()"), () =>
            {
                using (var db = DB.DBCon.GetCMDataContext())
                {
                    return db.fn_List_News(null).Select(s => new News
                    {                        
                        NewsID=s.NewsID,
                        NewsDate=s.NewsDate,
                        Title=s.Title,
                        Description=s.Description,
                        FullText=s.FullText,
                        LangID=s.LangID,
                        CategoryID=s.CategoryID,
                        SortVal=s.SortVal,
                        IsVisible=s.IsVisible,
                        VideoURL=s.VideoURL,
                        GalleryID=s.GalleryID
                    }).ToList();
                }
            });
        }

        public void SP_News(int? iud, int NewsID, DateTime? NewsDate, string Title, string Description, string FullText, int? LangID, int? CategoryID, int? SortVal,
                            bool? IsVisible, string VideoURL, int? GalleryID)
        {
            TryExecute(string.Format(@"Core.CM.NewsRepository.ListNews(iud = {0}, NewsID={1}, NewsDate{2}, Title{3}, Description{4}, FullText{5}, LangID{6}, CategoryID{7}, SortVal{8}, 
            IsVisible{9}, VideoURL{10}, GalleryID{11}", iud, NewsID, NewsDate, Title, Description, FullText, LangID, CategoryID, SortVal,
            IsVisible, VideoURL, GalleryID), () =>
            {
                using (var db = DB.DBCon.GetCMDataContext())
                {
                    int? NewID = NewsID;
                    db.sp_News(iud, ref NewID, NewsDate, Title, Description, FullText, LangID, CategoryID, SortVal, IsVisible, VideoURL, GalleryID);
                    this.ID = NewID;
                }
            });
        }

    }

}
