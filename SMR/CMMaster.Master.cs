using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using Core.Tools;

namespace SMR
{
    public partial class CMMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadPlugins();
        }
        public void LoadPlugins()
        {
            var IncludePlugins = new StringBuilder();
            IncludePlugins.Append(Plugins.bootstrapCSS());
            IncludePlugins.Append(Plugins.normalizeCSS());
            IncludePlugins.Append(Plugins.jqueryJS());
            IncludePlugins.Append(Plugins.modernizrJS());
            IncludePlugins.Append(Plugins.bootstrapJS());            
            litPlugins.Text = IncludePlugins.ToString();
        }
    }
}