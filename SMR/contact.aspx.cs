using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SMR
{
    public partial class contact : Models.PageBase
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
            }
            var ContactPage = new Core.CM.PagesRepository().ListPages(9).FirstOrDefault();

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
            var M= new Core.Tools.Mail();
            string Body= string.Format("სახელი:{0} {3} ელ.ფოსტა:{1} {3} წერილი: {2}",txtName.Text,txtEmail.Text,txtMessage.Text,Environment.NewLine);
            M.Send(Core.Properties.Resources.EmailAddress, Core.Properties.Resources.EmailAddress, "საკონტაქტო გვერდი", Body);
            Response.Redirect(Request.Url.OriginalString);
        }
    }
    
}