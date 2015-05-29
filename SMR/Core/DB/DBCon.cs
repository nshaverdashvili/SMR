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
        public static GeneralDataContext GetGeneralDataContext()
        {
            return new GeneralDataContext(ConfigurationManager.ConnectionStrings["DBConString"].ConnectionString);
        }
    }
}
