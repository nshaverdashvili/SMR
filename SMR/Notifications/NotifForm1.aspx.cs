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
    public partial class NotifForm1 : Models.PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            initErrorMessages();
            btnAddnew.Text = Core.Properties.Resources.Send;
        }
        void initErrorMessages()
        {
            reqOrgName.ErrorMessage = string.Format(Core.Properties.Resources.WarningRequired, Core.Properties.Resources.OrganizationName);
            reqAddress.ErrorMessage = Core.Properties.Resources.Address;
            reqMobile.ErrorMessage = Core.Properties.Resources.Telephone;
            reqEmail.ErrorMessage = Core.Properties.Resources.Email;
            reqWebPage.ErrorMessage = Core.Properties.Resources.WebPage;
            reqAppUpload.ErrorMessage = Core.Properties.Resources.ApplicableUpload;
            reqMissionDesc.ErrorMessage = Core.Properties.Resources.MissionDesc;
            reqHumDesc.ErrorMessage = Core.Properties.Resources.HumDesc;
            reqContactForm1.ErrorMessage = Core.Properties.Resources.ContactForm1;
            reqHumType.ErrorMessage = Core.Properties.Resources.HumType;
            reqHumQuantity.ErrorMessage = Core.Properties.Resources.HumQuantity;
            reqDonors.ErrorMessage = Core.Properties.Resources.Donor_s_;
            reqTerms.ErrorMessage = Core.Properties.Resources.EmerHum;
            reqDireqtions.ErrorMessage = Core.Properties.Resources.HumDirection;
            reqAddInfo.ErrorMessage = Core.Properties.Resources.AddInfo;
            reqOrgName1.ErrorMessage = Core.Properties.Resources.OrganizationName;
            reqAddress1.ErrorMessage = Core.Properties.Resources.Address;
            reqMobile1.ErrorMessage = Core.Properties.Resources.Telephone;
            reqEmail2.ErrorMessage = Core.Properties.Resources.Email;
            reqWebPage2.ErrorMessage = Core.Properties.Resources.WebPage;
            reqMissionDesc2.ErrorMessage = Core.Properties.Resources.MissionDesc;
            reqContact2.ErrorMessage = Core.Properties.Resources.ContactForm1;
            reqProjectTitle.ErrorMessage = Core.Properties.Resources.ProjectName;
            reqProjectStatus.ErrorMessage = Core.Properties.Resources.StatusOfProject;
            reqDonors2.ErrorMessage = Core.Properties.Resources.Donor_s_;
            reqProjectGoal2.ErrorMessage = Core.Properties.Resources.AimOfProject;
            reqProjectResults2.ErrorMessage = Core.Properties.Resources.ExpectedResults;
            reqProjectFDate.ErrorMessage = Core.Properties.Resources.FDate;
            reqProjectLDate.ErrorMessage = Core.Properties.Resources.LDate;
            reqOrgName2.ErrorMessage = Core.Properties.Resources.OrganizationName;
            reqAddress3.ErrorMessage = Core.Properties.Resources.Address;
            reqMobile3.ErrorMessage = Core.Properties.Resources.Telephone;
            reqEmail3.ErrorMessage = Core.Properties.Resources.Email;
            reqWebPage2.ErrorMessage = Core.Properties.Resources.WebPage;
            reqMissionDesc3.ErrorMessage = Core.Properties.Resources.MissionDesc;
            reqDonors3.ErrorMessage = Core.Properties.Resources.DonorsForm3;
            reqMissionDesc3.ErrorMessage = Core.Properties.Resources.MissionDesc;
            reqStatusOfProject3.ErrorMessage = Core.Properties.Resources.StatusOfProject;
            reqContacts3.ErrorMessage = Core.Properties.Resources.ContactForm1;
            reqProjectTitle3.ErrorMessage = Core.Properties.Resources.ProjectName;
            reqStatus3.ErrorMessage = Core.Properties.Resources.StatusOfProject;
            reqDonors3.ErrorMessage = Core.Properties.Resources.DonorsForm2;
            reqProjectGoal3.ErrorMessage = Core.Properties.Resources.PurposeofVisit;
            reqFDate3.ErrorMessage = Core.Properties.Resources.FDate;
            reqLDate3.ErrorMessage = Core.Properties.Resources.LDate;
            reqFinanceInfo.ErrorMessage = Core.Properties.Resources.FinanceInfo;
            reqPartnerInfo.ErrorMessage = Core.Properties.Resources.LocalPartner;
            reqSchedule.ErrorMessage = Core.Properties.Resources.Schedule;
        }

    }
}