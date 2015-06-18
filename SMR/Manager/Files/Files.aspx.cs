using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxUploadControl;
using System.IO;

namespace SMR.Manager.Files
{
    public partial class Files : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UploadFile_FilesUploadComplete(object sender, FilesUploadCompleteEventArgs e)
        {
            var FileUploader = (sender as ASPxUploadControl);
            var Ext = Path.GetExtension(FileUploader.FileName);
            var FileName = string.Format("{0}{1}",Guid.NewGuid().ToString().Substring(1, 6),Ext);
            Session["FileName"] = FileName;
            var pth = string.Format("{0}{1}", Core.Tools.Utility.GetUploadFolder(), FileName);
            FileUploader.SaveAs(pth);
        }
    }
}