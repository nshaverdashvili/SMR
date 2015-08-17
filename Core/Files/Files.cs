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
        public int? TypeID { get; set; }
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
                        TypeID=s.TypeID
                    }).ToList();
                }
            });
        }

        public void SP_Files(int? iud, int? FileID, string FileName, string DescriptionEN, string DescriptionKA, string DescriptionRU, string URL, int? TypeID)
        {
            TryExecute(string.Format("SP_Files(iud = {0}, FileID = {1}, FileName = {2}, DescriptionEN = {3}, DescriptionKA = {4}, DescriptionRU = {5}, URL = {6}, TypeID = {7})", iud, FileID, FileName, DescriptionEN, DescriptionKA, DescriptionRU, URL, TypeID), () =>
            {
                var FilePath=string.Format("{0}\\{1}",Utility.GetUploadFolder(), URL);
                if (File.Exists(FilePath) && iud==2)
                {
                    File.Delete(FilePath);
                }

                using (var db = DB.DBCon.GetFilesDataContext())
                {
                    int? NewID = FileID;
                    db.sp_Files(iud, ref NewID, FileName, DescriptionEN, DescriptionKA, DescriptionRU, URL, TypeID);
                    this.ID = NewID;
                }
            });
        }


    }
}
