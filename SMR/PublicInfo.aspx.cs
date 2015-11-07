using Core.CM;
using Core.Files;
using SMR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SMR
{
    public partial class WebForm1 : PageBase
    {
        List<Files> ListFiles = new List<Files>();
        protected void Page_Load(object sender, EventArgs e)
        {
            int _ID;
            if (int.TryParse(Request.QueryString["ID"], out _ID))
            {
                var N = new PagesRepository();
                var F = new FilesRepository();
                var SinglePage = N.ListPages(_ID).SingleOrDefault();

                if (SinglePage != null)
                {
                    ltrTitle.Text = SinglePage.Title;
                    ltrFullText.Text = SinglePage.Description;
                    ListFiles = F.ListGalleryFiles(SinglePage.GalleryID).Where(w => w.FileName != null && w.FileName.Length > 1).ToList();
                    rptFileGroups.DataSource = ListFiles.GroupBy(g => g.FileName).Select(s => new Files { FileName = s.Key });
                    rptFileGroups.DataBind();
                }
            }


            if (!IsPostBack)
            {
                if (Session["IsSent"] != null)
                {
                    litScripts.Text = "<script> alert('მონაცემები გადაგზავნილია')</script>";
                    Session["IsSent"] = null;
                }
            }
            var ContactPage = new Core.CM.PagesRepository().ListPages(40).FirstOrDefault();

            litContacinfo.Text = ContactPage.Description;
            initErrorMessages();
        }

        void initErrorMessages()
        {
            btnSend.Text = Core.Properties.Resources.Send;
            reqName.ErrorMessage = Core.Properties.Resources.Name_ContactPage;
            reqEmail.ErrorMessage = Core.Properties.Resources.Email;
            reqMessage.ErrorMessage = Core.Properties.Resources.Message_ContactPage;
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            var M = new Core.Tools.Mail();
            string Body = string.Format("სახელი:{0} {3} ელ.ფოსტა:{1} {3} წერილი: {2}", txtName.Text, txtEmail.Text, txtMessage.Text, Environment.NewLine);
            M.Send(Core.Properties.Resources.EmailAddress, Core.Properties.Resources.EmailAddress, "საკონტაქტო გვერდი", Body);
            Response.Redirect(Request.Url.OriginalString);
        }






        protected void rptFileGroups_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                var GroupName = ((Files)e.Item.DataItem).FileName;
                var SubList = ListFiles.Where(w => w.FileName == GroupName);
                if (SubList.Any())
                {
                    var rpt = (Repeater)e.Item.FindControl("rptFiles");
                    rpt.DataSource = SubList;
                    rpt.DataBind();

                }
            }
        }
    }
}