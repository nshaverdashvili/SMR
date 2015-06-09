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
    }

}
