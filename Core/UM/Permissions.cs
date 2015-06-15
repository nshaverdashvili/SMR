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
        public int? Level { get; set; }
        public string Caption { get; set; }
        public string PageName { get; set; }
        public string PermissionsCode { get; set; }
        public string CodeName { get; set; }
        public int? SortVal { get; set; }
        public bool? IsVisible { get; set; }
    }
    public class UserPermissions
    {
        public int RecordID { get; set; }
        public int? UserID { get; set; }
        public int? PermissionID { get; set; }
        public bool? IsGrant { get; set; }
    }

    public class PermissionsRepository : ObjectBase
    {
        public int? ID { get; set; }
        public List<Permissions> ListPermissions()
        {
            return TryToReturn(string.Format("Core.UM.PermissionsRepository.ListPermissions()"), () =>
            {
                using (var db = DB.DBCon.GetUMDataContext())
                {
                    return db.fn_List_Permissions().Select(s => new Permissions
                    {
                        Level=s.Level,
                        PermissionID=s.PermissionID,
                        ParentID=s.ParentID,
                        Caption=s.Caption,
                        PageName=s.PageName,
                        CodeName=s.CodeName,
                        SortVal=s.SortVal,
                        IsVisible=s.isVisible,
                        PermissionsCode=s.PermissionCode
                    }).ToList();
                }
            });
        }

        public void SP_Permissions(byte? iud, int? PermissionID=null, int? ParentID=null, string Caption=null, string PageName=null, string CodeName=null, int? SortVal=null, bool? IsVisible=null)
        {
            TryExecute(string.Format(@"Core.UM.PermissionsRepository(iud = {0}, PermissionID = {1}, ParentID = {2}, Caption = {3}, PageName = {4}, CodeName = {5}, SortVal = {6}, IsVisible = {7} )", iud, PermissionID, ParentID, Caption, PageName, CodeName, SortVal, IsVisible), () =>
            {
                using (var db = DB.DBCon.GetUMDataContext())
                {
                    int? NewID = PermissionID;
                    db.sp_Permissions(iud, ref NewID, ParentID, Caption, PageName, CodeName, SortVal, IsVisible);
                    this.ID = NewID;
                }
            });
        }
    }
    
    public class UserPermissionsRepository : ObjectBase
    {
        public int? ID { get; set; }
        public List<Permissions> ListUserPermissions(long UserID)
        {
            return TryToReturn(string.Format("Core.UM.UserPermissionsRepository.ListUserPermissions()"), () =>
            {
                using (var db = DB.DBCon.GetUMDataContext())
                {
                    return db.fn_List_UserPermissions(UserID).Select(s => new Permissions
                    {
                        PermissionID=s.PermissionID,
                        Caption=s.Caption,
                        PageName=s.PageName,
                        CodeName=s.PermissionCode,
                        IsVisible=s.isVisible
                    }).ToList();
                }
            });
        }


        public void SP_UserPermissions(int? iud, int? RecordID = null, int? UserID = null, int? PermissionID = null, bool? IsGrant = null)
        {
            TryExecute(string.Format(@"Core.UM.UserPermissionsRepository(iud = {0}, RecordID = {1}, UserID = {2}, PermissionID = {3}, IsGrant = {4})", iud, RecordID, UserID, PermissionID, IsGrant), () =>
            {
                using (var db = DB.DBCon.GetUMDataContext())
                {
                    int? NewID = RecordID;
                    db.sp_UserPermissions(iud, ref NewID, UserID, PermissionID, IsGrant);
                    this.ID = NewID;
                }
            });
        }


    }
}
