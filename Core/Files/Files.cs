using Core.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemBase;
using System.Threading;

namespace Core.Files
{
    public class Files
    {
        public int? FileID { get; set; }
        public int? RecordID { get; set; }
        public string FileName { get; set; }
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
        public string URL { get; set; }
        public string URLKa { get; set; }
        public string URLRu { get; set; }
        public int? TypeID { get; set; }
        public bool? IsDefault { get; set; }
    }
    public class FilesRepository : ObjectBase
    {
        public int? ID { get; set; }
        public List<Files> ListFiles(int? FileID=null)
        {
            return TryToReturn(string.Format("Core.Files.FilesRepository.ListFiles()"), () =>
            {
                using (var db = DB.DBCon.GetFilesDataContext())
                {
                    return db.fn_List_Files(FileID).Select(s => new Files
                    {
                        FileID=s.FileID,
                        FileName = s.FileName,
                        DescriptionEN = s.DescriptionEN,
                        DescriptionKA = s.DescriptionKA,
                        DescriptionRU = s.DescriptionRU,
                        URL=s.URL,
                        URLKa = s.URLKa,
                        URLRu = s.URLRu,
                        TypeID=s.TypeID
                    }).ToList();
                }
            });
        }

        public void SP_Files(int? iud, int? FileID, string FileName, string DescriptionEN, string DescriptionKA, string DescriptionRU, string URL, string URLKa, string URLRu, int? TypeID)
        {
            TryExecute(string.Format("SP_Files(iud = {0}, FileID = {1}, FileName = {2}, DescriptionEN = {3}, DescriptionKA = {4}, DescriptionRU = {5}, URL = {6}, URLKa = {7}, URLRu = {8}, TypeID = 9})", iud, FileID, FileName, DescriptionEN, DescriptionKA, DescriptionRU, URL, URLKa, URLRu, TypeID), () =>
            {
                var FilePath=string.Format("{0}\\{1}",Utility.GetUploadFolder(), URL);
                var FilePathKa=string.Format("{0}\\{1}",Utility.GetUploadFolder(), URLKa);
                var FilePathRu=string.Format("{0}\\{1}",Utility.GetUploadFolder(), URLRu);
                if (File.Exists(FilePath) && iud==2)
                {
                    File.Delete(FilePath);
                }

                using (var db = DB.DBCon.GetFilesDataContext())
                {
                    int? NewID = FileID;
                    db.sp_Files(iud, ref NewID, FileName, DescriptionEN, DescriptionKA, DescriptionRU, URL, URLKa, URLRu, TypeID);
                    this.ID = NewID;
                }
            });
        }
        public List<Files> ListGalleryFiles(int? GalleryID)
        {
            return TryToReturn(string.Format("ListGalleryFiles(GalleryID={0})", GalleryID), () =>
            {
                using (var db = DB.DBCon.GetFilesDataContext())
                {
                    return db.fn_List_GalleryFiles(GalleryID).Select(s => new Files
                    {
                        RecordID=s.RecordID,
                        FileID = s.FileID,
                        FileName = s.FileName,
                        DescriptionEN = s.DescriptionEN,
                        DescriptionKA = s.DescriptionKA,
                        DescriptionRU = s.DescriptionRU,
                        URL = s.URL,
                        URLKa = s.URLKa,
                        URLRu = s.URLRu,
                        TypeID = s.TypeID,
                        IsDefault = s.IsDefault
                    }).ToList();
                }
            });

        }
        public void SP_GalleryFiles(int? iud, int? RecordID, int? GalleryID, int? FileID, bool? IsDefault)
        {
            TryExecute(string.Format("SP_GalleryFiles(iud = {0},  RecordID = {1} , GalleryID = {2}, FileID = {3}, IsDefault = {4})", iud, RecordID, GalleryID, FileID, IsDefault), () =>
            {
                using (var db = DB.DBCon.GetFilesDataContext())
                {
                    int? NewID = RecordID;
                    db.sp_GalleryFiles(iud, ref NewID, GalleryID, FileID, IsDefault);
                    this.ID = NewID;
                }
            });
        }
    }
    
}
