using Core.Files;
using Core.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lib;

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
                txtFileNameEn.Text = item.FileNameEn;
                txtFileNameKA.Text = item.FileNameKa;
                txtFileNameRU.Text = item.FileNameRu;
                txtDescriptionEN.Text = item.DescriptionEN;
                txtDescriptionKA.Text = item.DescriptionKA;
                txtDescriptionRU.Text = item.DescriptionRU;
                hfURLka.Value =
                litUrlka.Text = item.URLKa;
                ddFileType.SelectedValue = item.TypeID.ToString();
               

                hfURLen.Value =
                litUrlen.Text = item.URLEn;
                

                hfURLru.Value =
                litUrlru.Text = item.URLRu;
               
            }
           
        }

        string SaveFile(FileUpload fuURL, string FileName)
        {
            var FilePath = string.Format("{0}\\{1}", Utility.GetUploadFolder(), FileName);
            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
            }

            var ext = Path.GetExtension(fuURL.FileName);
            if (".jpg .png .pdf .docx".Contains(ext.ToLower()))
            {
                FileName = fuURL.FileName.ToAZ09Dash(true,true);
                fuURL.SaveAs(string.Format("{0}\\{1}", Utility.GetUploadFolder(), FileName));
                return FileName;
            }
            else
            {
                litMsg.Text = "არსებული ფაილის ტვირთვა შეუძლებელია, ფორმატი არასწორია";
                return FileName;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            msgPH.Visible = true;
            var FileNameka = hfURLka.Value;
            var FileNameen = hfURLen.Value;
            var FileNameru = hfURLru.Value;
            var iud = (byte)(_ID > 0 ? 1 : 0);

            if (fuURLka.HasFile)
            {
                FileNameka = SaveFile(fuURLka, FileNameka);
            }
            if (fuURLen.HasFile)
            {
                FileNameen = SaveFile(fuURLen, FileNameen);
            }
            if (fuURLru.HasFile)
            {
                FileNameru = SaveFile(fuURLru, FileNameru);
            }

            fr.SP_Files(iud, _ID, txtFileNameKA.Text, txtFileNameEn.Text, txtFileNameRU.Text, txtDescriptionEN.Text, txtDescriptionKA.Text, txtDescriptionRU.Text, FileNameen, FileNameka, FileNameru, Convert.ToInt32(ddFileType.SelectedValue));
            if (fr.IsError)
            {
                litMsg.Text = "ოპერაცია არ შესრულდა: "+fr.ErrorMessage;
                return;
            }
                litMsg.Text = "<script>$(function(){window.parent.gridFiles.Refresh(); window.parent.ClosePopupPage();});</script>";
            
        }
    }
}