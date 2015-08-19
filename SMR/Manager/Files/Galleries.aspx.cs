using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SMR.Manager.Files
{
    public partial class Galleries : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridGalleryFiles_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            var grid=(DevExpress.Web.ASPxGridView.ASPxGridView)sender;
            var keyValue=grid.GetMasterRowKeyValue();
            dsGalleryFiles.InsertParameters["GalleryID"].DefaultValue = keyValue.ToString();
        }

        protected void GridGalleryFiles_RowUpdated(object sender, DevExpress.Web.Data.ASPxDataUpdatedEventArgs e)
        {
            var grid = (DevExpress.Web.ASPxGridView.ASPxGridView)sender;
            var keyValue = grid.GetMasterRowKeyValue();
            dsGalleryFiles.UpdateParameters["GalleryID"].DefaultValue = keyValue.ToString();
        }

        protected void GridGalleryFiles_BeforePerformDataSelect(object sender, EventArgs e)
        {
            var grid = (DevExpress.Web.ASPxGridView.ASPxGridView)sender;
            var keyValue = grid.GetMasterRowKeyValue();
            dsGalleryFiles.SelectParameters["GalleryID"].DefaultValue = keyValue.ToString();
        }
    }
}