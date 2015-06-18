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
        public string Title { get; set; }
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
                        Title=s.Title,
                        Description=s.Description,
                        LangID=s.LangID
                    }).ToList();
                }
            });
        }
        public void SP_Galleries(byte? iud = null, int? RecordID = null, string Title = null, string Description = null, int? LangID = null)
        {
            TryExecute(string.Format(@"Core.Files.GalleryRepository(iud	= {0}, RecordID	= {1}, Title = {2}, 
            Description = {3}, LangID = {4})", iud, RecordID, Title, Description, LangID), () =>
                             {
                                 using (var db = DB.DBCon.GetFilesDataContext())
                                 {
                                     int? NewID = RecordID;
                                     db.sp_Gallery(iud, ref NewID, Title, Description, LangID);
                                     this.ID = NewID;
                                 }
                             });
        }
    



    }
    
}
