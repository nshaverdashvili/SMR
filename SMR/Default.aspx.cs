﻿using Core.CM;
using Core.UM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SMR
{
    public partial class Default : Models.PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            InitStartup();
        }
        private void InitStartup()
        {
            var p = new NewsRepository();
            rptNews.DataSource = p.ListNews(null).Where(w => w.IsVisible.Value && !string.IsNullOrEmpty(w.Description)).OrderByDescending(o => o.NewsDate).Take(5);
            rptNews.DataBind();
        }
    }
}