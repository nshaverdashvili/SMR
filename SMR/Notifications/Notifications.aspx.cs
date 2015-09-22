using Core.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lib;
using Core.UM;

namespace SMR.Notifications
{
    public partial class Notifications : Models.PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            initErrorMessages();
        }

        void initErrorMessages() {
            reqFname.ErrorMessage = Core.Properties.Resources.PersonalInformation;
        }
    }
}