using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using Core.Tools;
using Core.UM;

namespace SMR
{
    public partial class CMMaster : System.Web.UI.MasterPage
    {
        public bool EnableCalendar
        {
            get
            {
                return phCalendar.Visible;
            }
            set
            {
                phCalendar.Visible = value;
            }
        }
        PermissionsRepository p = new PermissionsRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            InitStartup();
            LoadPlugins();

        }
        private void LoadPlugins()
        {
            var IncludePlugins = new StringBuilder();

            IncludePlugins.Append(Plugins.bootstrapCSS());
            IncludePlugins.Append(Plugins.normalizeCSS());
            IncludePlugins.Append(Plugins.awesomefontsCSS());
            IncludePlugins.Append(Plugins.jqueryUICSS());
            IncludePlugins.Append(Plugins.jqueryJS());
            IncludePlugins.Append(Plugins.jqueryUIJS());
            IncludePlugins.Append(Plugins.modernizrJS());
            IncludePlugins.Append(Plugins.bootstrapJS());
            IncludePlugins.Append(Plugins.jssorJS());
            litPlugins.Text = IncludePlugins.ToString();

        }
        private void InitStartup()
        {

            rptMainManu.DataSource = p.ListPermissions().Where(w => w.Level == 1 && w.CodeName == "1" && w.Caption != " ");
            rptMainManu.DataBind();
            rptLeftManu.DataSource = p.ListPermissions().Where(w => w.Level == 1 && w.CodeName == "3" && w.Caption != " ");
            rptLeftManu.DataBind();

        }

        protected void rptMainManu_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                var ParentID = ((Permissions)e.Item.DataItem).PermissionID;
                var SubMnuList = p.ListChildPermissions(ParentID);
                if (SubMnuList.Any())
                {
                    var rpt = (Repeater)e.Item.FindControl("rptSubMnu");
                    rpt.DataSource = SubMnuList;
                    rpt.DataBind();

                }
            }
        }

        protected void LangChange_OnClick(object sender, EventArgs e)
        {
            var Culture = CultureHelper.GetImplementedCulture(((LinkButton)sender).ToolTip);
            var cookie = Request.Cookies["CurrentLanguage"];
            if (cookie!= null)
            {
                cookie.Value = Culture;
            }
            else
            {
                cookie = new HttpCookie("CurrentLanguage");
                cookie.Value = Culture;
                cookie.Expires = DateTime.Now.AddYears(1);
            }
            Response.Cookies.Add(cookie);
            Response.Redirect(Request.Url.OriginalString);
        }
    }
}