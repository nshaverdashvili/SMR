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
using System.Globalization;
using System.IO;
using System.Net.Mail;

namespace SMR.Notifications
{
    public partial class NotifForm1 : Models.PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Session["IsSent"] != null)
            {
                litScripts.Text = "<script> alert('მონაცემები გადაგზავნილია')</script>";
                Session["IsSent"] = null;
            }
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

            var fuURLFileName2 = "";

            if (fuURL2.HasFile)
            {
                fuURLFileName2 = fuURL2.FileName.ToAZ09Dash(true, true);
                var path = string.Format("{0}//Notifications//", Utility.GetUploadFolder());

                fuURL2.SaveAs(string.Format("{0}{1}", path, fuURLFileName2));
            }

            var fuURLNoteFile = "";

            if (fuURLNote.HasFile)
            {
                fuURLNoteFile = fuURLNote.FileName.ToAZ09Dash(true, true);
                var path = string.Format("{0}//Notifications//", Utility.GetUploadFolder());

                fuURLNote.SaveAs(string.Format("{0}{1}", path, fuURLNoteFile));                
            }

            var fuURLNoteFile1 = "";

            if (fuURLNote1.HasFile)
            {
                fuURLNoteFile1 = fuURLNote1.FileName.ToAZ09Dash(true, true);
                var path = string.Format("{0}//Notifications//", Utility.GetUploadFolder());

                fuURLNote1.SaveAs(string.Format("{0}{1}", path, fuURLNoteFile1));
            }

            var fuURLNoteFile2 = "";

            if (fuURLNote2.HasFile)
            {
                fuURLNoteFile2 = fuURLNote2.FileName.ToAZ09Dash(true, true);
                var path = string.Format("{0}//Notifications//", Utility.GetUploadFolder());

                fuURLNote2.SaveAs(string.Format("{0}{1}", path, fuURLNoteFile2));
            }
            
            var NotifType = new DictionariesRepository().ListDictionary(1, 9).FirstOrDefault(w => w.CodeVal == Convert.ToInt32(hfNotifyType.Value)).DictionaryID;
/*
            N.SP_Notifications(0,
                NotificationTypeID: NotifType,
                OrgName : txtOrgName.Text,
                Address: txtAddress.Text,
                Mobile: txtMobile.Text,
                Email: txtEmail.Text,
                WebPage: txtWebPage.Text,
                URL: fuURLFileName,
                MissionDesc: txtMissionDesc.Text,
                Contact: txtContact.Text,
                Desc1: txtDesc1.Text,
                Desc2: txtDesc2.Text,
                Number: txtNumber.Text,
                Donors: txtDonors.Text,
                Term: txtTerms.Text,
                Proportions: txtProportions.Text,
                RegFileURL: fuURLNoteFile
                );
 */
        //if (!N.IsError)
            {
                var NObj = new Core.Notifications();
                switch (hfNotifyType.Value)
                {
                    case "2":
                        NObj.NotificationTypeID = NotifType;
                        NObj.OrgName = txtOrgName.Text;
                        NObj.Address = txtAddress.Text;
                        NObj.Mobile = txtMobile.Text;
                        NObj.Email = txtEmail.Text;
                        NObj.WebPage = txtWebPage.Text;
                        NObj.URL = fuURLFileName;
                        NObj.MissionDesc = txtMissionDesc.Text;
                        NObj.Contact = txtContact.Text;
                        NObj.Desc1 = txtDesc1.Text;
                        NObj.Desc2 = txtDesc2.Text;
                        NObj.Number = txtNumber.Text;
                        NObj.Donors = txtDonors.Text;
                        NObj.Term = txtTerms.Text;
                        NObj.Proportions = txtProportions.Text;
                        NObj.RegFileURL = fuURLNoteFile;
                        Session["IsSent"] = MakeNotification(NObj);
                        break;
                    case "3":
                        NObj.NotificationTypeID = NotifType;
                        NObj.OrgName = txtOrgName1.Text;
                        NObj.Address = txtAddress1.Text;
                        NObj.Mobile = txtMobile1.Text;
                        NObj.Email = txtEmail1.Text;
                        NObj.WebPage = txtWebPage1.Text;
                        //NObj.URL = fuURLFileName2;
                        NObj.MissionDesc = txtMissionDesc1.Text;
                        NObj.Contact = txtContact1.Text;
                        NObj.ProjectTitle = txtProjectTitle.Text;
                        //NObj.Donors = txtDonors1.Text;
                        NObj.ProjectStatus = txtProjectStatus.Text;
                        //NObj.Term = txtTerms.Text;
                        NObj.Donors = txtDonors1.Text;
                        NObj.Term = txtProjectGoal1.Text;
                        NObj.ProjectResults = txtProjectResults1.Text;
                        NObj.ProjectFDate = DateTime.Parse(txtProjectFDate.Text);
                        NObj.ProjectLDate = DateTime.Parse(txtProjectLDate.Text);
                        //NObj.Proportions = txtProportions.Text;
                        NObj.RegFileURL = fuURLNoteFile1;
                        Session["IsSent"] = MakeNotification(NObj);
                        break;
                    case "4":
                        NObj.NotificationTypeID = NotifType;
                        NObj.OrgName = txtOrgName2.Text;
                        NObj.Address = txtAddress2.Text;
                        NObj.Mobile = txtMobile2.Text;
                        NObj.Email = txtEmail2.Text;
                        NObj.WebPage = txtWebPage2.Text;
                        NObj.URL = fuURLFileName2;                        
                        NObj.MissionDesc = txtMission2.Text;
                        NObj.IsActualProjects = bool.Parse(txtIsActive2.Text); // es rogor unda iyos??
                        NObj.ProjectTitle = txtProjectTitle2.Text;
                        NObj.ProjectStatus = txtProjectStatus2.Text;
                        NObj.Donors = txtDonorContacts.Text;
                        NObj.Term = txtProjectGoal2.Text;
                        NObj.ProjectResults = txtProjectResults1.Text;
                        NObj.ProjectFDate = DateTime.Parse(txtProjectFDate.Text);
                        NObj.ProjectLDate = DateTime.Parse(txtProjectLDate.Text);
                        NObj.FinanceInfo = txtFinanceInfo.Text;
                        NObj.PartnerInfo = txtPartnerInfo.Text;
                        NObj.DepartPlan = txtDepart.Text;
                        NObj.RegFileURL = fuURLNoteFile2;

                        Session["IsSent"] = MakeNotification(NObj);
                        break;
                }

                //NObj.Desc1 = txtDesc1.Text;
                //NObj.Desc2 = txtDesc2.Text;
                //NObj.Number = txtNumber.Text;

                
                Response.Redirect(Request.Url.OriginalString);

  
            }

        }

        private bool MakeNotification(Core.Notifications NObj)
        {
            try
            {
                var M = new Core.Tools.Mail();
                var ms = new MemoryStream();
                var ListAtt = new List<Attachment>();

                var FileName = string.Format("Notification_{0:yyyy-MM-dd}_{1}.pdf", DateTime.Now, Guid.NewGuid().ToString().Substring(1, 6));
                switch (hfNotifyType.Value)
                {
                    case "2":
                        var rpt2 = new rptNotifForm1(NObj);
                        rpt2.ExportToPdf(ms);
                        break;
                    case "3":
                        var rpt3 = new rptNotifForm2(NObj);
                        rpt3.ExportToPdf(ms);
                        break;
                    case "4":
                        var rpt4 = new rptNotifForm3(NObj);
                        rpt4.ExportToPdf(ms);
                        break;

                }


                ms.Seek(0, System.IO.SeekOrigin.Begin);

                var attach = new Attachment(ms, FileName, "application/pdf");
                ListAtt.Add(attach);

                M.Send("ninashaverdashvili@gmail.com", "ninashaverdashvili@gmail.com", "სანოტიიკაციო ფორმა", "ინფორმაცია საიტიდან", AttachmentsList: ListAtt);
                ms.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
           
        }
    }
}