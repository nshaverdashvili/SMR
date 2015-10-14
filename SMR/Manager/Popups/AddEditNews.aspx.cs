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
                txtDate.Text = string.Format("{0:yyyy-MM-dd}", item.NewsDate);
                txtTitleEN.Text = item.TitleEN;
                txtTitleKA.Text = item.TitleKA;
                txtTitleRU.Text = item.TitleRU;
                txtDescEN.Text = item.DescriptionEN;
                txtDescKA.Text = item.DescriptionKA;
                txtDescRU.Text = item.DescriptionRU;
                txtFulltxtEN.Text = item.FullTextEN;
                txtFullTextKA.Text = item.FullTextKA;
                txtFullTextRU.Text = item.FullTextRU;
                txtSortVal.Text = string.Format("{0}", item.SortVal);
                chkVisible.Checked = item.IsVisible.Value;
                chkVisibleSliderEN.Checked = item.IsVisibleSliderEN.Value;
                chkVisibleSliderKA.Checked = item.IsVisibleSliderKA.Value;
                chkVisibleSliderRU.Checked = item.IsVisibleSliderRU.Value;
                    if (item.GalleryID != null)
                    ddGalleryID.SelectedValue = item.GalleryID.ToString();
                txtVideoURL.Text = item.VideoURL;
            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            msgPH.Visible = true;
            var iud = (byte)(_ID > 0 ? 1 : 0);
            Nr.SP_News(iud, _ID, DateTime.Parse(txtDate.Text), txtTitleEN.Text, txtTitleKA.Text, txtTitleRU.Text, txtDescEN.Text, txtDescKA.Text, txtDescRU.Text, 
                txtFulltxtEN.Text, txtFullTextKA.Text, txtFullTextRU.Text,
               int.Parse(ddCategoryID.SelectedValue), int.Parse(string.IsNullOrEmpty(txtSortVal.Text) ? "0" : txtSortVal.Text), chkVisible.Checked, chkVisibleSliderEN.Checked, chkVisibleSliderKA.Checked, chkVisibleSliderRU.Checked, txtVideoURL.Text, int.Parse(ddGalleryID.SelectedValue)
               );
            if (Nr.IsError)
            {
                litMsg.Text = "ოპერაცია არ შესრულდა: " + Nr.ErrorMessage;
                return;
            }
            litMsg.Text = "<script>$(function(){window.parent.gridNews.Refresh(); window.parent.ClosePopupPage();});</script>";
            
        }
    }
}