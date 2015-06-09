using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemBase;

namespace Core.UM
{
    public class Permissions
    {
        public int PermissionID { get; set; }
        public int? ParentID { get; set; }
        public string Caption { get; set; }
        public string PageName { get; set; }
        public string CodeName { get; set; }
        public int? SortVal { get; set; }
        public bool? IsVisible { get; set; }
    }
    public class PermissionsRepository : ObjectBase
    {

    }

    public class UserPermissions
    {
        public int RecordID { get; set; }
        public int? UserID { get; set; }
        public int? PermissionID { get; set; }
        public bool? IsGrant { get; set; }
    }
    public class UserPermissionsRepository : ObjectBase
    {

    }
}
