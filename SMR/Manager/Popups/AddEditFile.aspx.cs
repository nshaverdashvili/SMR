using Core.Files;
using Core.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SMR.Manager.Popups
{
    public partial class AddEditFile : Models.PageBase
    {
        int _ID;
        FilesRepository fr = new FilesRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (int.TryParse(Request.QueryString["fid"],out _ID) && !IsPostBack)
            {
                LoadData();
            }
        }

        void LoadData()
        {
            var item = fr.ListFiles(_ID).SingleOrDefault();
            if (item != null)
            {
                txtFileName.Text = item.FileName;
                txtDesc.Text = item.Description;
                hfURL.Value =
                litUrl.Text = item.URL;
                ddFileType.SelectedValue = item.TypeID.ToString();
            }
           
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            var FileName = hfURL.Value;
            var iud = (byte)(_ID > 0 ? 1 : 0);

            if (fuURL.HasFile)
            {
                var FilePath=string.Format("{0}\\{1}", Utility.GetUploadFolder(), FileName);
                if (File.Exists(FilePath))
                {
                    File.Delete(FilePath);
                }

                var ext = Path.GetExtension(fuURL.FileName);
                if (".jpg .png .pdf .docx".Contains(ext))
                {
                    FileName = string.Format("{0}{1}", Guid.NewGuid().ToString().Substring(0, 6), ext);
                    fuURL.SaveAs(string.Format("{0}\\{1}", Utility.GetUploadFolder(), FileName));
                }
                else
                {
                    litMsg.Text = "არსებული ფაილის ტვირთვა შეუძლებელია, ფორმატი არასწორია";
                    return;
                }
            }

            fr.SP_Files(iud, _ID, txtFileName.Text, txtDesc.Text, FileName, Convert.ToInt32(ddFileType.SelectedValue));
            if (fr.IsError)
            {
                litMsg.Text = fr.ErrorMessage;
            }
            else
            {
                litMsg.Text = "<script>$(function(){window.parent.gridFiles.Refresh(); window.parent.ClosePopupPage();});</script>";
            }

        }
    }
}