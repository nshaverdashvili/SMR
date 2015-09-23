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
            reqFname.ErrorMessage = Core.Properties.Resources.FirstName;
            reqLname.ErrorMessage = Core.Properties.Resources.LastName;
            reqAddress.ErrorMessage = Core.Properties.Resources.Address;
            reqMobile.ErrorMessage = Core.Properties.Resources.Telephone;
            reqFax.ErrorMessage = Core.Properties.Resources.Fax;
            reqEmail.ErrorMessage = Core.Properties.Resources.Email;
            reqPassportN.ErrorMessage = Core.Properties.Resources.PassportNumber;
            reqNationality.ErrorMessage = Core.Properties.Resources.Nationality;
            reqBDate.ErrorMessage = Core.Properties.Resources.Dateofbirth;
            reqGender.ErrorMessage = Core.Properties.Resources.Gender;
            reqFDate.ErrorMessage = Core.Properties.Resources.FDate;
            reqLDate.ErrorMessage = Core.Properties.Resources.LDate;
            reqOrganisator.ErrorMessage = Core.Properties.Resources.VisitOrganizedby;
            reqFName1.ErrorMessage = Core.Properties.Resources.FirstName;
            reqLName1.ErrorMessage = Core.Properties.Resources.LastName;
            reqAddress.ErrorMessage = Core.Properties.Resources.Address;
            reqMobile1.ErrorMessage = Core.Properties.Resources.Telephone;
            reqProject.ErrorMessage = Core.Properties.Resources.ProjectImplemented;

        }
    }
}
