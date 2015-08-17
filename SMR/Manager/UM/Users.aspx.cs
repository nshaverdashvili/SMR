using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SMR.Manager.UM
{
    public partial class Users : Models.PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void gridUsers_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            var NewValue = (string)e.NewValues["Password"];
            var OldValue = (string)e.OldValues["Password"];

            if (NewValue==OldValue)
            {
                e.NewValues["Password"] = null;
            }
        }

    }
}