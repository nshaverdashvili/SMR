using Core.CM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SMR
{
    public partial class NewsList : Models.PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.EnableCalendar = true;
            InitStartup();
        }
        private void InitStartup()
        {
            var p = new NewsRepository();
            rptNews.DataSource = p.ListNews(null).Where(w => w.IsVisible.Value).OrderByDescending(o => o.NewsDate);
            rptNews.DataBind();
        }
    }
}