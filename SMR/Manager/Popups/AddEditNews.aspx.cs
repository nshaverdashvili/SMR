using Core.CM;
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
        }

        void LoadData()
        {
            var item = Nr.ListNews(_ID).SingleOrDefault();
            if (item !=null)
            {
                ddGalleryID.SelectedValue = item.CategoryID.ToString();
                txtDate.Text = item.NewsDate.ToString();
                txtTitle.Text = item.Title;
                txtDesc.Text = item.Description;
                txtFullText.Text = item.FullText;
                chkVisible.Checked = item.IsVisible.Value;
                ddGalleryID.SelectedValue = item.GalleryID.ToString();
                txtVideoURL.Text = item.VideoURL;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}