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

    public class UserRoles
    {
        public int RecordID { get; set; }
        public int? UserID { get; set; }
        public int? RoleID { get; set; }
        public bool? IsGrant { get; set; }
    }

    public class RolesRepository : ObjectBase
    {
        public int? ID { get; set; }
        public List<Roles> ListRoles()
        {
            return TryToReturn(string.Format("Core.UM.RolesRepository.ListRoles()"), () =>
                {
                    using (var db = DB.DBCon.GetUMDataContext())
                    {
                        return db.fn_List_Roles().Select(s => new Roles
                            {
                                RoleID = s.RoleID,
                                Caption = s.Caption,
                                Code = s.Code
                            }).ToList();
                    }
                });
        }
        public void SP_Roles(byte? iud, int? RoleID = null, string Caption = null, int? Code = null)
        {
            TryExecute(string.Format(@"Core.UM.RolesRepository(iud = {0}, RoleID = {1}, Caption = {2}, Code = {3})", iud, RoleID, Caption, Code), () =>
            {
                using (var db = DB.DBCon.GetUMDataContext())
                {
                    int? NewID = RoleID;
                    db.sp_Roles(iud, ref NewID, Caption, Code);
                    this.ID = NewID;
                }
            });
        }
        
    }

    public class UserRolesRepository : ObjectBase
    {
        public int? ID { get; set; }
        public List<Roles> ListUserRoles(long UserID)
        {
            return TryToReturn(string.Format("Core.UM.UserRolesRepository.ListUserRoles()"), () =>
            {
                using (var db = DB.DBCon.GetUMDataContext())
                {
                    return db.fn_List_UserRoles(UserID).Select(s => new Roles
                    {
                        RoleID = s.RoleID,
                        Caption = s.Caption,
                        Code = s.Code
                    }).ToList();
                }
            });
        }

        public void SP_UserRoles(int? iud, int? RecordID = null, int? UserID = null, int? RoleID = null, bool? IsGrant = null)
        {
            TryExecute(string.Format(@"Core.UM.UserRolesRepository(iud = {0}, RecordID = {1}, UserID = {2}, RoleID = {3}, IsGrant = {4})", iud, RecordID, UserID, RoleID, IsGrant), () =>
            {
                using (var db = DB.DBCon.GetUMDataContext())
                {
                    int? NewID = RoleID;
                    db.sp_UserRoles(iud, ref NewID, UserID, RoleID, IsGrant);
                    this.ID = NewID;
                }
            });
        }

    }

}
