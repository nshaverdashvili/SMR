using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tools
{
    public class Plugins
    {
        public static string jqueryJS()
        {
            return string.Format("<script type=\"text/javascript\" src=\"/Plugins/jquery/jquery-1.11.3.min.js\"></script>");
        }

        public static string jqueryUIJS()
        {
            return string.Format("<script type=\"text/javascript\" src=\"/Plugins/jqueryUI/jquery-ui.min.js\"></script>");
        }

        public static string jqueryUICSS()
        {
            return string.Format("<link rel=\"stylesheet\" type=\"text/css\" href=\"/Plugins/jqueryUI/jquery-ui.min.css \" /> <link rel=\"stylesheet\" type=\"text/css\" href=\"/Plugins/jqueryUI/jquery-ui.theme.min.css\" />");
        }
        public static string modernizrJS()
        {
            return string.Format("<script type=\"text/javascript\" src=\"/Plugins/modernizr/modernizr.js\"></script>");
        }
        public static string bootstrapJS()
        {
            return string.Format("<script type=\"text/javascript\" src=\"/Plugins/bootstrap/js/bootstrap.min.js\"></script>");
        }
        public static string bootstrapCSS()
        {
            return string.Format("<link rel=\"stylesheet\" type=\"text/css\" href=\"/Plugins/bootstrap/css/bootstrap.min.css  \" /> <link rel=\"stylesheet\" type=\"text/css\" href=\"/Plugins/bootstrap/css/bootstrap-theme.css\" />");
        }
        public static string normalizeCSS()
        {
            return string.Format("<link rel=\"stylesheet\" type=\"text/css\" href=\"/Plugins/normalize/normalize.css  \" />");
        }
        public static string fancyboxJS()
        {
            return string.Format("<script type=\"text/javascript\" src=\"/Plugins/fancybox/jquery.fancybox.js\"></script>");
        }
        public static string fancyboxCSS()
        {
            return string.Format("<link rel=\"stylesheet\" type=\"text/css\" href=\"/Plugins/fancybox/jquery.fancybox.css  \" />");
        }
        public static string jssorJS()
        {
            return string.Format("<script type=\"text/javascript\" src=\"/Plugins/jssor/jquery-1.9.1.min.js\"></script> <script type=\"text/javascript\" src=\"/Plugins/jssor/jssor.slider.mini.js\"></script>");
        }
    }

}
