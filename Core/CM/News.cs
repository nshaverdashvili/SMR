using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SystemBase;

namespace Core.CM
{
    public class News
    {
        public int? NewsID { get; set; }
        public DateTime? NewsDate { get; set; }
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
        public string DescriptionEN { get; set; }
        public string DescriptionKA { get; set; }
        public string DescriptionRU { get; set; }
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
        public string FullTextEN { get; set; }
        public string FullTextKA { get; set; }
        public string FullTextRU { get; set; }
        public string FullText {
            get
            {
                if (Thread.CurrentThread.CurrentUICulture.Name == "ka-GE")
                {
                    return FullTextKA;
                }
                if (Thread.CurrentThread.CurrentUICulture.Name == "ru-RU")
                {
                    return FullTextRU;
                }
                return FullTextEN;
            }
        }
        public int? CategoryID { get; set; }
        public int? SortVal { get; set; }
        public bool? IsVisible { get; set; }
        public string VideoURL { get; set; }
        public int? GalleryID { get; set; }
    }
    public class NewsRepository : ObjectBase
    {
        public int? ID { get; set; }
        public List<News> ListNews(int? NewsID)
        {
            return TryToReturn(string.Format("Core.CM.NewsRepository.ListNews()"), () =>
            {
                using (var db = DB.DBCon.GetCMDataContext())
                {
                    return db.fn_List_News(NewsID).Select(s => new News
                    {                        
                        NewsID=s.NewsID,
                        NewsDate=s.NewsDate, 
                        TitleEN=s.TitleEN,
                        TitleKA = s.TitleKA,
                        TitleRU = s.TitleRU,
                        DescriptionEN = s.DescriptionEN,
                        DescriptionKA = s.DescriptionKA,
                        DescriptionRU = s.DescriptionRU,
                        FullTextEN=s.FullTextEN,
                        FullTextKA = s.FullTextKA,
                        FullTextRU = s.FullTextRU,
                        CategoryID=s.CategoryID,
                        SortVal=s.SortVal,
                        IsVisible=s.IsVisible,
                        VideoURL=s.VideoURL,
                        GalleryID=s.GalleryID
                    }).ToList();
                }
            });
        }

        public void SP_News(int? iud, int NewsID, DateTime? NewsDate, string TitleEN,string TitleKA,string TitleRU, string DescriptionEN,string DescriptionKA,string DescriptionRU, string FullTextEN, string FullTextKA, string FullTextRU, int? LangID, int? CategoryID, int? SortVal,
                            bool? IsVisible, string VideoURL, int? GalleryID)
        {
            TryExecute(string.Format("SP_News(iud = {0}, NewsID = {1}, NewsDate = {2}, TitleEN = {3}, TitleKA = {4}, TitleRU = {5}, DescriptionEN = {6}, DescriptionKA = {7}, DescriptionRU = {8}, FullTextEN = {9}, FullTextKA = {10}, FullTextRU = {11}, LangID = {12}, CategoryID = {13}, SortVal = {14}, IsVisible = {15}, VideoURL = {16}, GalleryID = {17})", 
                iud, NewsID, NewsDate, TitleEN, TitleKA, TitleRU, DescriptionEN, DescriptionKA, DescriptionRU, 
                FullTextEN, FullTextKA, FullTextRU, LangID, CategoryID, SortVal, IsVisible, VideoURL, GalleryID), () =>
            {
                using (var db = DB.DBCon.GetCMDataContext())
                {
                    int? NewID = NewsID;
                    db.sp_News(iud, ref NewID, NewsDate, TitleEN, TitleKA, TitleRU, DescriptionEN, DescriptionKA, DescriptionRU, FullTextEN, FullTextKA, FullTextRU, CategoryID, SortVal, IsVisible, VideoURL, GalleryID);
                    this.ID = NewID;
                }
            });
        }

    }

}
