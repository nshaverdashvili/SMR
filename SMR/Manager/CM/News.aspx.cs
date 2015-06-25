using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Core.Tools;
using DevExpress.Web.ASPxGridView;


namespace SMR.Manager.CM
{
    public partial class News : Models.PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            litHeader.Text += Plugins.fancyboxCSS();
            litHeader.Text += Plugins.fancyboxJS();
        }
    }
}