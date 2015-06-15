using Core.UM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace SMR.Models
{
    public class AdminMasterBase : MasterPage
    {
        public string CurrentPageName
        {
            get { return Request.Url.Segments.Last(); }
        }
        public Users UserObject { get; set; }
        protected void Page_Init(object sender, EventArgs e)
        {
           
            if (!UserRepository.IsAuthenticated()) {
                Response.Redirect("~/Manager/Login.aspx?url=" + Request.Url.AbsolutePath + Request.Url.Query);
                return;
            }

            UserObject = UserRepository.UserObject;

            if (!HasPermission())
                Response.Redirect("~/Manager/Login.aspx");
        }

        private bool HasPermission()
        {
            return UserObject.IsAdmin || UserObject.Permissions.Any(a => !string.IsNullOrEmpty(a.PageName) && a.PageName.ToLower().Contains(CurrentPageName.ToLower()));
        }

    }
}
