﻿using Core.CM;
using Core.Files;
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

        public string ogUrl;
        public string ogTitle;
        public string ogDescription;
        public string ogImg;

        protected void Page_Load(object sender, EventArgs e)
        {
            
            var N = new NewsRepository();
            int _ID;
            if (int.TryParse(Request.QueryString["ID"], out _ID))
            {
                var SingleNews = N.ListNews(_ID).SingleOrDefault();
                
                if (SingleNews != null)
                {
                    ltrImgURL.Text = string.Format("<a href=\"/Uploads/{0}\" class=\"mainImg\"  data-showpopup='true'><img src=\"Uploads/{0}?w=200\" /></a>", SingleNews.ImgURL);
                    ogTitle=
                    ltrTitle.Text = SingleNews.Title;

                    ogDescription = SingleNews.Description;
                    ogUrl = "http://new.smr.gov.ge/NewsDetails.aspx?ID=" + SingleNews.NewsID;
                    ogImg = "http://new.smr.gov.ge/Uploads/" + SingleNews.ImgURL;

                    ltrDate.Text = string.Format("{0:dd/MM/yyyy}", SingleNews.NewsDate);
                    ltrFulltxt.Text = SingleNews.FullText;

                    var G = new FilesRepository();
                    rptNewsGallery.DataSource = G.ListGalleryFiles(SingleNews.GalleryID).Where(w => !w.IsDefault.Value);
                    rptNewsGallery.DataBind();


                }

            }

        }
    }
}