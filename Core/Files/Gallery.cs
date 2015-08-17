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
        public int? RecordID { get; set; }
        public string TitleEN { get; set; }
        public string TitleKA { get; set; }
        public string TitleRU { get; set; }
        public string Title { get; set; }
        public string DescriptionEN { get; set; }
        public string DescriptionKA { get; set; }
        public string DescriptionRU { get; set; }
        public string Description { get; set; }
        public int? LangID { get; set; }
    }
    public class GalleryRepository : ObjectBase
    {
        public int? ID { get; set; }
        public List<Gallery> ListGallery()
        {
            return TryToReturn(string.Format("Core.Files.GalleryRepository.ListGallery()"), () =>
            {
                using (var db = DB.DBCon.GetFilesDataContext())
                {
                    return db.fn_List_Gallery(null).Select(s => new Gallery
                    {
                        RecordID=s.RecordID,
                        TitleEN=s.TitleEN,
                        TitleKA = s.TitleKA,
                        TitleRU = s.TitleRU,
                        DescriptionEN = s.DescriptionEN,
                        DescriptionKA = s.DescriptionKA,
                        DescriptionRU = s.DescriptionRU
                    }).ToList();
                }
            });
        }
        public void SP_Galleries(byte? iud = null, int? RecordID = null, string TitleEN = null, string TitleKA = null, string TitleRU = null,  string DescriptionEN = null, string DescriptionKA = null, string DescriptionRU = null)
        {
            TryExecute(string.Format("SP_Galleries(iud = {0}, RecordID = {1}, TitleEN = {2}, TitleKA = {3}, TitleRU = {4}, DescriptionEN = {5}, DescriptionKA = {6}, DescriptionRU = {7})", iud, RecordID, TitleEN, TitleKA, TitleRU, DescriptionEN, DescriptionKA, DescriptionRU), () =>
                             {
                                 using (var db = DB.DBCon.GetFilesDataContext())
                                 {
                                     int? NewID = RecordID;
                                     db.sp_Gallery(iud, ref NewID, TitleEN, TitleKA, TitleRU, DescriptionEN, DescriptionKA, DescriptionRU);
                                     this.ID = NewID;
                                 }
                             });
        }
    



    }
    
}