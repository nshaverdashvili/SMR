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

namespace SMR.Manager
{
    public partial class LogIn : Models.PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadPlugins();
            InitStartup();
        }

        void InitStartup() {
            btnLogin.Text = Core.Properties.Resources.Login;
        }

        protected void LoadPlugins()
        {
            var IncludePlugins = new StringBuilder();
            IncludePlugins.Append(Plugins.bootstrapCSS());
            IncludePlugins.Append(Plugins.jqueryJS());
            IncludePlugins.Append(Plugins.modernizrJS());
            IncludePlugins.Append(Plugins.bootstrapJS());
            litPlugins.Text = IncludePlugins.ToString();
        }

        protected void btnLang_Click(object sender, EventArgs e)
        {
            LanguageHandler.ChangLang(sender, e);
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (UserRepository.Authenticate(txtUserName.Text, txtPassword.Text.MD5()))
            {
                Response.Redirect("~/manager/Default.aspx");
            }
            else
            {
                litErrorMessage.Text = Core.Properties.Resources.WorningWrongPassword;
            }
        }
    }
}