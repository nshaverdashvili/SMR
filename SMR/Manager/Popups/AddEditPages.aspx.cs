using System;
using System.Collections.Generic;
using Core.CM;
using Core.Tools;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace SMR.Manager.Popups
{
    public partial class AddEditPages : Models.PageBase // System.Web.UI.Page
    {
        int _ID;
        PagesRepository pr = new PagesRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (int.TryParse(Request.QueryString["id"], out _ID) && !IsPostBack)
            {
                LoadData();
            }
            litHead.Text = Plugins.tinymceJS();
        }
        void LoadData()
        {
            
         var item = pr.ListPages(_ID).SingleOrDefault();
         if (item != null)
         {
             txtTitleEN.Text = item.TitleEN;
             txtTitleKA.Text = item.TitleKA;
             txtTitleRU.Text = item.TitleRU;
             txtDescEN.Text = item.DescriptionEN;
             txtDescKA.Text = item.DescriptionKA;
             txtDescRU.Text = item.DescriptionRU;
             txtNote.Text = item.Note;
             chkVisible.Checked = item.IsVisible.Value;
             if (item.GalleryID != null)
                 ddGalleryID.SelectedValue = item.GalleryID.ToString();
             if (item.TemplateID != null)
                 ddTemplateID.SelectedValue = item.TemplateID.ToString();
             txtURL.Text = item.URL;
         }
        }



        protected void btnSave_Click(object sender, EventArgs e)
        {
            msgPH.Visible = true;
            var iud = (byte)(_ID > 0 ? 1 : 0);
            pr.SP_Pages(iud, _ID, null, txtTitleEN.Text, txtTitleKA.Text, txtTitleRU.Text, txtDescEN.Text, txtDescKA.Text, txtDescRU.Text, int.Parse(ddTemplateID.SelectedValue),
                txtURL.Text, txtNote.Text, int.Parse(ddGalleryID.SelectedValue), chkVisible.Checked);
            if (pr.IsError)
            {
                litMsg.Text = "ოპერაცია არ შესრულდა: " + pr.ErrorMessage;
                return;
            }
            litMsg.Text = "<script>$(function(){window.parent.gridPages.Refresh(); window.parent.ClosePopupPage();});</script>";

        }

    }
}