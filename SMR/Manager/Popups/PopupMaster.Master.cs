using Core.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SMR.Manager.Popups
{
    public partial class PopupMaster : Models.AdminMasterBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadPlugins();
        }

        protected void LoadPlugins()
        {
            var IncludePlugins = new StringBuilder();
            IncludePlugins.Append(Plugins.bootstrapCSS());
            IncludePlugins.Append(Plugins.normalizeCSS());
            IncludePlugins.Append(Plugins.jqueryUICSS());
            IncludePlugins.Append(Plugins.jqueryJS());
            IncludePlugins.Append(Plugins.modernizrJS());
            IncludePlugins.Append(Plugins.bootstrapJS());
            IncludePlugins.Append(Plugins.jqueryUIJS());
            litPlugins.Text = IncludePlugins.ToString();
        }
    }
}