using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Web;
namespace Core.Tools
{    
    public class LanguageHandler
    {
        public static void InitLanguage(LinkButton btnLang)
        {
            
        }
        public static void ChangLang(object sender, EventArgs e)
        {
            var cookie = new HttpCookie("CurrentLanguage");
            var btnLang = (LinkButton)sender;
            switch (btnLang.Text)
            {
                case "En":
                    cookie.Value = "en-US";
                    break;
                case "Ge":
                    cookie.Value = "ka-GE";
                    break;
                case "Ru":
                    cookie.Value = "ru-RU";
                    break;
                default:
                    cookie.Value = "ka-GE";
                    break;
            }
            HttpContext.Current.Response.SetCookie(cookie);
            HttpContext.Current.Response.Redirect(HttpContext.Current.Request.RawUrl);
        }
    }
}
