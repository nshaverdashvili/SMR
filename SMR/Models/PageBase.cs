using System.Web.UI;
using System.Globalization;
using System.Web;

namespace SMR.Models
{
    public class PageBase : Page
    {
        public string CurrentLanguage { get { return System.Threading.Thread.CurrentThread.CurrentCulture.ToString(); } }
        protected override void InitializeCulture()
        {
            var lang = string.Empty;
            var cookie = Request.Cookies["CurrentLanguage"];
            if (cookie != null && cookie.Value != null)
            {
                lang = cookie.Value;
                var Cult = CultureInfo.CreateSpecificCulture(lang);
                System.Threading.Thread.CurrentThread.CurrentUICulture = Cult;
                System.Threading.Thread.CurrentThread.CurrentCulture = Cult;
            }
            else
            {
                if (string.IsNullOrEmpty(lang)) lang = "ka-GE";
                var Cult = CultureInfo.CreateSpecificCulture(lang);
                System.Threading.Thread.CurrentThread.CurrentUICulture = Cult;
                System.Threading.Thread.CurrentThread.CurrentCulture = Cult;
                var cookieNew = new HttpCookie("CurrentLanguage") {Value = lang};
                Response.SetCookie(cookieNew);
            }

            base.InitializeCulture();
        }
    }
}
