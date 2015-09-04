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

            rptMainManu.DataSource = p.ListPermissions().Where(w => w.Level == 1 && w.CodeName == "1");
            rptMainManu.DataBind();
            rptLeftManu.DataSource = p.ListPermissions().Where(w => w.Level == 1 && w.CodeName == "3");
            rptLeftManu.DataBind();
            rptFooterManu.DataSource = p.ListPermissions().Where(w => w.Level == 1 && w.CodeName == "1");
            rptFooterManu.DataBind();

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
    }
}