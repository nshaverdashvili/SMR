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

namespace SMR.Notifications
{
    public partial class Notifications : Models.PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["IsSent"] != null)
                {
                    litScripts.Text = "<script> alert('მონაცემები გადაგზავნილია')</script>";
                    Session["IsSent"] = null;
                }

                ddBDay.DataSource = Utility.List_RangeOfNumbers(1, 31).Select(s => new { Value = s }).ToList();
                ddBDay.DataBind();
                ddBMonth.DataSource = DateTimeFormatInfo.CurrentInfo.MonthNames.Select((item, index) => new { Caption = item, Value = index+1 }).ToList(); //Utility.List_RangeOfNumbers(1, 12).Select(s => new { Value = s }).ToList();
                ddBMonth.DataBind();
                ddBYear.DataSource = Utility.List_RangeOfNumbers(1900, 2015).Select(s => new { Value = s }).ToList();
                ddBYear.DataBind();
                

            }
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
            var NotifType = new DictionariesRepository().ListDictionary(1, 9).FirstOrDefault(w => w.CodeVal == 1).DictionaryID;
            var BDate = new DateTime(Convert.ToInt32(ddBYear.SelectedValue), Convert.ToInt32(ddBMonth.SelectedValue), Convert.ToInt32(ddBDay.SelectedValue));
            var EnteryDate = string.IsNullOrEmpty(txtFDate.Text) ? DateTime.Now : DateTime.Parse(txtFDate.Text);
            var LeaveDate = string.IsNullOrEmpty(txtLDate.Text) ? DateTime.Now : DateTime.Parse(txtLDate.Text);
            /*
            N.SP_Notifications(0,
                NotificationTypeID: NotifType,
                URL: fuURLFileName,
                FName: txtFName.Text,
                LName: txtLName.Text,
                Address: txtAddress.Text,
                Mobile: txtMobile.Text,
                Fax: txtFax.Text,
                Email: txtEmail.Text,
                PassportN: txtPassportN.Text,
                Nationality: txtNationality.Text,
                BDate: BDate,
                Gender: bool.Parse(ddGender.SelectedValue),
                EnteryDate: EnteryDate,
                LeaveDate: LeaveDate,
                Organisator: ddOrganisator.SelectedValue,
                TransportType: ddTransportType.SelectedValue,
                Destination: txtDestination.Text,
                HostName: txtHostName.Text,
                HostContact: txtHostContact.Text,
                EmFName : txtFName1.Text,
                EmLName: txtLName1.Text,
                EmAddress: txtAddress1.Text,
                EmMobile: txtMobile1.Text,
                VisitorStatus : txtProjectStatus.Text,
                ProjectTitle:  txtProjectName.Text,
                ProjectNote	:txtProjectGoal.Text,
                ProjectFDate: DateTime.Parse(txtProjectFDate.Text),
                ProjectLDate:DateTime.Parse(txtProjectLDate.Text),
                Partner: txtLocalPartner.Text,
                IsSent	: bool.Parse(ddIsSent.SelectedValue),
                Note: txtNote.Text);
            if (!N.IsError)
            {
             */
                var NotifyObject = new Core.Notifications
                {
                    NotificationTypeID = NotifType,
                    URL = fuURLFileName,
                    FName = txtFName.Text,
                    LName = txtLName.Text,
                    Address = txtAddress.Text,
                    Mobile = txtMobile.Text,
                    Fax = txtFax.Text,
                    Email = txtEmail.Text,
                    PassportN = txtPassportN.Text,
                    Nationality = txtNationality.Text,
                    BDate = BDate,
                    //Sex = bool.Parse(ddGender.SelectedValue),
                    EnteryDate = EnteryDate,
                    LeaveDate = LeaveDate,
                    Organisator = ddOrganisator.SelectedValue,
                    TransportType = ddTransportType.SelectedValue,
                    Destination = txtDestination.Text,
                    HostName = txtHostName.Text,
                    HostContact = txtHostContact.Text,
                    EmFName = txtFName1.Text,
                    EmLName = txtLName1.Text,
                    EmAddress = txtAddress1.Text,
                    EmMobile = txtMobile1.Text,
                    VisitorStatus = txtProjectStatus.Text,
                    ProjectTitle = txtProjectName.Text,
                    ProjectNote = txtProjectGoal.Text,
                    ProjectFDate = DateTime.Parse(txtProjectFDate.Text),
                    ProjectLDate = DateTime.Parse(txtProjectLDate.Text),
                    Partner = txtLocalPartner.Text,
                    //IsSent = bool.Parse(ddIsSent.SelectedValue),
                    Note = txtNote.Text
                };

                var rpt = new rptNotification( NotifyObject );
                var FileName = string.Format("Notification_{0:yyyy-MM-dd}_{1}.pdf", DateTime.Now, Guid.NewGuid().ToString().Substring(1, 6));
                rpt.ExportToPdf(string.Format("{0}{1}", Utility.GetUploadFolder(), FileName));

                Session["IsSent"] = true;
                Response.Redirect(Request.Url.OriginalString);
            //}
        }
    }
}
