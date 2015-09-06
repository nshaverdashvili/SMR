using Core.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SMR.Manager.CM
{
    public partial class Pages : Models.PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            litHeader.Text += Plugins.fancyboxCSS();
            litHeader.Text += Plugins.fancyboxJS();
        }
    }
}