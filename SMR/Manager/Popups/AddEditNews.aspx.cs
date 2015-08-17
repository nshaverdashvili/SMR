using Core.CM;
using Core.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SMR.Manager.Popups
{
    public partial class AddEditNews : Models.PageBase
    {
        int _ID;
        NewsRepository Nr = new NewsRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (int.TryParse(Request.QueryString["nid"], out _ID) && !IsPostBack)
            {
                LoadData();
            }
            litHead.Text = Plugins.tinymceJS();
        }

        void LoadData()
        {
            var item = Nr.ListNews(_ID).SingleOrDefault();
            if (item !=null)
            {
                ddGalleryID.SelectedValue = item.CategoryID.ToString();
                txtDate.Text = string.Format("{0:dd/MM/yyyy}", item.NewsDate);
                txtTitleEN.Text = item.Title;
                txtTitleKA.Text = item.Title;
                txtTitleRU.Text = item.Title;
                txtDescEN.Text = item.Description;
                txtFullTextKA.Text = item.FullText;
                txtFullTextRU.Text = item.FullText;
                chkVisible.Checked = item.IsVisible.Value;
                ddGalleryID.SelectedValue = item.GalleryID.ToString();
                txtVideoURL.Text = item.VideoURL;
            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            msgPH.Visible = true;
            var iud = (byte)(_ID > 0 ? 1 : 0);
            Nr.SP_News(iud, _ID, DateTime.Parse(txtDate.Text), txtTitleEN.Text, txtTitleKA.Text, txtTitleRU.Text, txtDescEN.Text, txtDescKA.Text, txtDescRU.Text,  txtFullTextEN.Text, txtFullTextKA.Text, txtFullTextRU.Text,
                null, int.Parse(ddCategoryID.SelectedValue), null, chkVisible.Checked, txtVideoURL.Text, int.Parse(ddGalleryID.SelectedValue));
            if (Nr.IsError)
            {
                litMsg.Text = "ოპერაცია არ შესრულდა: " + Nr.ErrorMessage;
                return;
            }
            litMsg.Text = "<script>$(function(){window.parent.gridNews.Refresh(); window.parent.ClosePopupPage();});</script>";
            
        }
    }
}