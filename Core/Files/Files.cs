using Core.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemBase;

namespace Core.Files
{
    public class Files
    {
        public int? FileID { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
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
                        Description=s.Description,
                        URL=s.URL,
                        TypeID=s.TypeID
                    }).ToList();
                }
            });
        }

        public void SP_Files(int? iud, int? FileID, string FileName, string Description, string URL, int? TypeID)
        {
            TryExecute(string.Format(@"Core.Files.FilesRepository.ListFiles(iud = {0}, FileID = {1}, FileName = {2}, Description = {3}, URL = {4}, TypeID = {5})", iud, FileID, FileName, Description, URL, TypeID), () =>
            {
                var FilePath=string.Format("{0}\\{1}",Utility.GetUploadFolder(), URL);
                if (File.Exists(FilePath) && iud==2)
                {
                    File.Delete(FilePath);
                }

                using (var db = DB.DBCon.GetFilesDataContext())
                {
                    int? NewID = FileID;
                    db.sp_Files(iud, ref NewID, FileName, Description, URL, TypeID);
                    this.ID = NewID;
                }
            });
        }


    }
}
