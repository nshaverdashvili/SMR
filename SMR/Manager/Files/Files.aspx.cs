using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Core.Tools;
using DevExpress.Web.ASPxGridView;

namespace SMR.Manager.Files
{
    public partial class Files : Models.PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            litHeader.Text += Plugins.fancyboxCSS();
            litHeader.Text += Plugins.fancyboxJS();
        }

        protected void gridFiles_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            var grid = (ASPxGridView)sender;
            dsFiles.DeleteParameters["URL"].DefaultValue = e.Values["URL"] as string;
        }

    }
}