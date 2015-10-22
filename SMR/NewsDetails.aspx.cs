using Core.CM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SMR
{
    public partial class NewsDetails : Models.PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            var N = new NewsRepository();
            int _ID;
            if (int.TryParse(Request.QueryString["ID"], out _ID))
            {
                var SingleNews = N.ListNews(_ID).SingleOrDefault();
                if (SingleNews != null)
                {
                    ltrImgURL.Text = string.Format("<a href=\"Uploads/{0}\" class=\"mainImg\"  data-showpopup='true'><img src=\"Uploads/{0}?w=200\" /></a>", SingleNews.ImgURL);
                    ltrTitle.Text = SingleNews.Title;

                    ltrDate.Text = string.Format("{0:dd/MM/yyyy}", SingleNews.NewsDate);
                    ltrFulltxt.Text = SingleNews.FullText;
                }

            }

        }
    }
}