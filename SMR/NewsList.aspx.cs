using Core.CM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SMR
{
    public partial class NewsList : Models.PageBase
    {
        int? RowCount = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.EnableCalendar = true;
            if (!IsPostBack)
            {
                InitStartup(10, 0);
            }
            else
            {
                plcPaging.Controls.Clear();
                CreatePagingControl();
            }  
            
        }
        private void InitStartup(int take, int pageSize)
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

            var List = p.ListNews(null).Where(w => w.IsVisible.Value && !string.IsNullOrEmpty(w.Description)).OrderByDescending(o => o.NewsDate).ToList();

            if (!string.IsNullOrEmpty(Request.QueryString["im"]) && Request.QueryString["im"]=="true")
            {
                List = List.Where(w => w.NewsDate.Value.Month == Month && w.NewsDate.Value.Year == Year).ToList();
            }
            else
            {
                List = List.Where(w=>w.NewsDate == NewDate).ToList();
            }

           
            List = List.Take(take).Skip(pageSize).ToList();

            PagedDataSource page = new PagedDataSource();
            page.AllowCustomPaging = true;
            page.AllowPaging = true;
                      
            page.DataSource = List;
            page.PageSize = 10;
            rptNews.DataSource = page;
            rptNews.DataBind();

            if (!IsPostBack)
            {
                RowCount = List.Count;
                CreatePagingControl();
            }

        }

        private void CreatePagingControl()
        {
            for (int i = 0; i < (RowCount / 10) + 1; i++)
            {
                LinkButton lnk = new LinkButton();
                lnk.Click += new EventHandler(lbl_Click);
                lnk.ID = "lnkPage" + (i + 1).ToString();
                lnk.Text = (i + 1).ToString();
                plcPaging.Controls.Add(lnk);
            }
        }

        void lbl_Click(object sender, EventArgs e)
        {
            LinkButton lnk = sender as LinkButton;
            int currentPage = int.Parse(lnk.Text);
            int take = currentPage * 10;
            int skip = currentPage == 1 ? 0 : take - 10;
            InitStartup(take, skip);
        }
    }
}