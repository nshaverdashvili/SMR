using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace Core.DB
{
    public class DBCon
    {
        public static UMDataContext GetUMDataContext()
        {
            return new UMDataContext(ConfigurationManager.ConnectionStrings["DBConString"].ConnectionString);
        }
        public static CMDataContext GetCMDataContext()
        {
            return new CMDataContext(ConfigurationManager.ConnectionStrings["DBConString"].ConnectionString);
        }
        public static FilesDataContext GetFilesDataContext()
        {
            return new FilesDataContext(ConfigurationManager.ConnectionStrings["DBConString"].ConnectionString);
        }
        public static ToolsDataContext GetToolsDataContext()
        {
            return new ToolsDataContext(ConfigurationManager.ConnectionStrings["DBConString"].ConnectionString);
        }
    }
}
