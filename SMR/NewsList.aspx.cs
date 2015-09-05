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
            var NewDate = DateTime.Today;
            var Month = NewDate.Month;
            var Year = NewDate.Year;

            if (!string.IsNullOrEmpty(Request.QueryString["d"]))
            {
                NewDate = Convert.ToDateTime(Request.QueryString["d"]);
                Month = NewDate.Month;
                Year = NewDate.Year;
            }

            var List = p.ListNews(null).Where(w => w.IsVisible.Value).OrderByDescending(o => o.NewsDate).ToList();

            if (!string.IsNullOrEmpty(Request.QueryString["im"]) && Request.QueryString["im"]=="true")
            {
                List = List.Where(w => w.NewsDate.Value.Month == Month && w.NewsDate.Value.Year == Year).ToList();
            }
            else
            {
                List = List.Where(w=>w.NewsDate == NewDate).ToList();
            }

            rptNews.DataSource = List;
            rptNews.DataBind();
        }
    }
}