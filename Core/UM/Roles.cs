using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemBase;

namespace Core.UM
{
    public class Roles
    {
        public int RoleID { get; set; }
        public string Caption { get; set; }
        public int? Code { get; set; }
    }
    public class RolesRepository : ObjectBase
    {

    }
    public class UserRoles
    {
        public int RecordID { get; set; }
        public int? UserID { get; set; }
        public int? RoleID { get; set; }
        public bool? IsGrant { get; set; }
    }

    public class UserRolesRepository : ObjectBase
    {

    }

}
