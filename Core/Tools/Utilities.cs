using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Web;
using System.Configuration;
using System.Threading;
using SystemBase;
using System.Net.Mail;
using System.Web.Mail;

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
    public class Utility
    {
        public static string GetUploadFolder()
        {
            return ConfigurationManager.AppSettings["UploadFolder"];
        }


        public static List<int> List_RangeOfNumbers(int from, int Count) {
            return Enumerable.Range(from, Count).ToList();
        }
    }

    public class Mail : ObjectBase
    {
        #region Properties
        string _From;
        string _Username;
        string _Password;
        string _SMTP = "smtp.gmail.com";
        int _Port = 587;
        bool _EnableSSL = true;

        public string From
        {
            set { _From = value; }
            get { return _From; }
        }
        #endregion Properties

        #region Constructors
        public Mail() :
            this(Core.Properties.Resources.EmailAddress, Core.Properties.Resources.EmailPassword)
        {

        }

        public Mail(string Username, string Password)
        {
            _Username = Username;
            _Password = Password;
        }

        public Mail(string SMTP, int Port, string Username, string Password, string From, bool EnableSSL)
        {
            _SMTP = SMTP;
            _Username = Username;
            _Password = Password;
            _Port = Port;
            _From = From;
            _EnableSSL = EnableSSL;
        }
        #endregion Constructors

        #region Methods
        public bool Send(string From, string To, string Subject, string Body, string ReplyTo = null, List<Attachment> AttachmentsList = null)
        {
            return TryToReturn(string.Format("General.Mail.Send(From = {0}, To = {1}, Subject = {2}, Body = {3}, ReplyTo = {4})", From, To, Subject, Body, ReplyTo), () =>
            {
                Body = Body.Replace("http:", "");

                var M = new System.Web.Mail.MailMessage();
                M.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpserver", _SMTP);
                M.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpserverport", _Port);
                M.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusing", "2");
                //sendusing: cdoSendUsingPort, value 2, for sending the message using 
                //the network.

                //smtpauthenticate: Specifies the mechanism used when authenticating 
                //to an SMTP 
                //service over the network. Possible values are:
                //- cdoAnonymous, value 0. Do not authenticate.
                //- cdoBasic, value 1. Use basic clear-text authentication. 
                //When using this option you have to provide the user name and password 
                //through the sendusername and sendpassword fields.
                //- cdoNTLM, value 2. The current process security context is used to 
                // authenticate with the service.
                M.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1");
                //Use 0 for anonymous
                M.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", _Username);
                M.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", _Password);
                M.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpusessl", "true");
                M.From = To;
                M.To = To;
                M.Subject = Subject;
                M.BodyFormat = MailFormat.Html;
                M.BodyEncoding = Encoding.UTF8;
                M.Body = Body;
                if (AttachmentsList!=null)
                {
                    AttachmentsList.ForEach(f => M.Attachments.Add(f));
                }
                


                if (!string.IsNullOrWhiteSpace(ReplyTo))
                {
                    M.Headers.Add("Reply-To", ReplyTo);
                }

                SmtpMail.SmtpServer = string.Format("{0}:{1}", _SMTP, _Port);
                SmtpMail.Send(M);
                return true;
            });
        }
        #endregion Methods
    }

    public static class CultureHelper
    {
        // Valid cultures
        private static readonly List<string> ValidCultures = new List<string> { "af", "af-ZA", "sq", "sq-AL", "gsw-FR", "am-ET", "ar", "ar-DZ", "ar-BH", "ar-EG", "ar-IQ", "ar-JO", "ar-KW", "ar-LB", "ar-LY", "ar-MA", "ar-OM", "ar-QA", "ar-SA", "ar-SY", "ar-TN", "ar-AE", "ar-YE", "hy", "hy-AM", "as-IN", "az", "az-Cyrl-AZ", "az-Latn-AZ", "ba-RU", "eu", "eu-ES", "be", "be-BY", "bn-BD", "bn-IN", "bs-Cyrl-BA", "bs-Latn-BA", "br-FR", "bg", "bg-BG", "ca", "ca-ES", "zh-HK", "zh-MO", "zh-CN", "zh-Hans", "zh-SG", "zh-TW", "zh-Hant", "co-FR", "hr", "hr-HR", "hr-BA", "cs", "cs-CZ", "da", "da-DK", "prs-AF", "div", "div-MV", "nl", "nl-BE", "nl-NL", "en", "en-AU", "en-BZ", "en-CA", "en-029", "en-IN", "en-IE", "en-JM", "en-MY", "en-NZ", "en-PH", "en-SG", "en-ZA", "en-TT", "en-GB", "en-US", "en-ZW", "et", "et-EE", "fo", "fo-FO", "fil-PH", "fi", "fi-FI", "fr", "fr-BE", "fr-CA", "fr-FR", "fr-LU", "fr-MC", "fr-CH", "fy-NL", "gl", "gl-ES", "ka", "ka-GE", "de", "de-AT", "de-DE", "de-LI", "de-LU", "de-CH", "el", "el-GR", "kl-GL", "gu", "gu-IN", "ha-Latn-NG", "he", "he-IL", "hi", "hi-IN", "hu", "hu-HU", "is", "is-IS", "ig-NG", "id", "id-ID", "iu-Latn-CA", "iu-Cans-CA", "ga-IE", "xh-ZA", "zu-ZA", "it", "it-IT", "it-CH", "ja", "ja-JP", "kn", "kn-IN", "kk", "kk-KZ", "km-KH", "qut-GT", "rw-RW", "sw", "sw-KE", "kok", "kok-IN", "ko", "ko-KR", "ky", "ky-KG", "lo-LA", "lv", "lv-LV", "lt", "lt-LT", "wee-DE", "lb-LU", "mk", "mk-MK", "ms", "ms-BN", "ms-MY", "ml-IN", "mt-MT", "mi-NZ", "arn-CL", "mr", "mr-IN", "moh-CA", "mn", "mn-MN", "mn-Mong-CN", "ne-NP", "no", "nb-NO", "nn-NO", "oc-FR", "or-IN", "ps-AF", "fa", "fa-IR", "pl", "pl-PL", "pt", "pt-BR", "pt-PT", "pa", "pa-IN", "quz-BO", "quz-EC", "quz-PE", "ro", "ro-RO", "rm-CH", "ru", "ru-RU", "smn-FI", "smj-NO", "smj-SE", "se-FI", "se-NO", "se-SE", "sms-FI", "sma-NO", "sma-SE", "sa", "sa-IN", "sr", "sr-Cyrl-BA", "sr-Cyrl-SP", "sr-Latn-BA", "sr-Latn-SP", "nso-ZA", "tn-ZA", "si-LK", "sk", "sk-SK", "sl", "sl-SI", "es", "es-AR", "es-BO", "es-CL", "es-CO", "es-CR", "es-DO", "es-EC", "es-SV", "es-GT", "es-HN", "es-MX", "es-NI", "es-PA", "es-PY", "es-PE", "es-PR", "es-ES", "es-US", "es-UY", "es-VE", "sv", "sv-FI", "sv-SE", "syr", "syr-SY", "tg-Cyrl-TJ", "tzm-Latn-DZ", "ta", "ta-IN", "tt", "tt-RU", "te", "te-IN", "th", "th-TH", "bo-CN", "tr", "tr-TR", "tk-TM", "ug-CN", "uk", "uk-UA", "wen-DE", "ur", "ur-PK", "uz", "uz-Cyrl-UZ", "uz-Latn-UZ", "vi", "vi-VN", "cy-GB", "wo-SN", "sah-RU", "ii-CN", "yo-NG" };

        // Include ONLY cultures you are implementing
        private static readonly List<string> Cultures = new List<string> {
            "ka-GE",  // Georgian culture is the DEFAULT
            "en-US", // English NEUTRAL culture
            "ru-RU"  // Russian NEUTRAL culture           
        };

        /// <summary>
        /// Returns a valid culture name based on "Name" parameter. If "name" is not valid, it returns the default culture "ka-GE"
        /// </summary>
        /// <param name="Name">Culture's name (e.g. ka-GE)</param>
        public static string GetImplementedCulture(string Name)
        {
            // make sure it's not null
            if (string.IsNullOrEmpty(Name))
                return GetDefaultCulture(); // return Default culture

            // make sure it is a valid culture first
            if (!ValidCultures.Any(c => c.Equals(Name, StringComparison.InvariantCultureIgnoreCase)))
                return GetDefaultCulture(); // return Default culture if it is invalid


            // if it is implemented, accept it
            if (Cultures.Any(c => c.Equals(Name, StringComparison.InvariantCultureIgnoreCase)))
                return Name; // accept it



            // Find a close match. For example, if you have "en-US" defined and the user requests "en-GB", 
            // the function will return closes match that is "en-US" because at least the language is the same (ie English)  
            var n = GetNeutralCulture(Name);
            foreach (var c in Cultures)
                if (c.StartsWith(n))
                    return c;



            // else 
            // It is not implemented
            return GetDefaultCulture(); // return Default culture as no match found
        }

        /// <summary>
        /// Returns default culture name which is the first name decalared (e.g. ka-GE)
        /// </summary>
        /// <returns></returns>
        public static string GetDefaultCulture()
        {
            return Cultures[0]; // return Default culture

        }

        public static string GetNeutralCulture(string name)
        {
            if (!name.Contains("-")) return name;

            return name.Split('-')[0]; // Read first part only. E.g. "en", "es"
        }

        public static string GetCurrentCulture()
        {
            return Thread.CurrentThread.CurrentCulture.Name;
        }

        public static string GetCurrentNeutralCulture()
        {
            return GetNeutralCulture(Thread.CurrentThread.CurrentCulture.Name);
        }
    }
}
