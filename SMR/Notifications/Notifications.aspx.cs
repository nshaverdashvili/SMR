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
using Core;

namespace SMR.Notifications
{
    public partial class Notifications : Models.PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            initErrorMessages();
        }

        void initErrorMessages()
        {
            btnSend.Text = Core.Properties.Resources.Send;
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
            //reqOrganisator.ErrorMessage = Core.Properties.Resources.VisitOrganizedby;
            reqFName1.ErrorMessage = Core.Properties.Resources.FirstName;
            reqLName1.ErrorMessage = Core.Properties.Resources.LastName;
            reqAddress.ErrorMessage = Core.Properties.Resources.Address;
            reqMobile1.ErrorMessage = Core.Properties.Resources.Telephone;
            reqProject.ErrorMessage = Core.Properties.Resources.ProjectImplemented;
            reqProjectStatus.ErrorMessage = Core.Properties.Resources.StatusNeutralDocs;
            reqProjectName.ErrorMessage = Core.Properties.Resources.ProjectName;
            reqProjectGoal.ErrorMessage = Core.Properties.Resources.PurposeofVisit;
            reqProjectFDate.ErrorMessage = Core.Properties.Resources.FDate;
            reqProjectLDate.ErrorMessage = Core.Properties.Resources.LDate;
            reqLocalPartner.ErrorMessage = Core.Properties.Resources.LocalPartner;
            reqIsSent.ErrorMessage = Core.Properties.Resources.IsSentProject;
            reqNote.ErrorMessage = Core.Properties.Resources.Provideadditionalinformation;


        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            var N = new NoficicationsRepository();
            var fuURLFileName = "";
            if (fuURL.HasFile)
            {
                fuURLFileName = fuURL.FileName.ToAZ09Dash(true, true);
                var path = string.Format("{0}//Notifications//", Utility.GetUploadFolder());

                fuURL.SaveAs(string.Format("{0}{1}", path, fuURLFileName));
            }

            //N.SP_Notifications(0,null, fuURLFileName, txtFName.Text, txtLName.Text, txtAddress.Text, txtMobile.Text, txtFax.Text, txtEmail.Text,
            //    txtPassportN.Text, txtNationality.Text, DateTime.Parse(txtBDate.Text), );
         


        }
    }
}
