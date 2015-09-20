using Core.CM;
using SMR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SMR
{
    public partial class detailsPage : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var N = new PagesRepository();
            int _ID;
            if (int.TryParse(Request.QueryString["ID"], out _ID))
            {
                var SingleNews = N.ListPages(_ID).SingleOrDefault();
                if (SingleNews != null)
                {
                    if (!string.IsNullOrEmpty(SingleNews.FileUrl))
                    {
                        ltrImgURL.Text = string.Format("<img src=\"/Uploads/{0}?w=400\" />", SingleNews.FileUrl);     
                    }                   
                    ltrTitle.Text = SingleNews.Title;
                    ltrFulltxt.Text = SingleNews.Description;
                }

            }
        }
    }
}