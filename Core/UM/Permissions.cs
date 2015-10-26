using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SystemBase;


namespace Core.UM
{
    public class Permissions
    {
        public int PermissionID { get; set; }
        public int? ParentID { get; set; }
        public int? Level { get; set; }
        public string CaptionEN { get; set; }
        public string CaptionKA { get; set; }
        public string CaptionRU { get; set; }
        public string Caption
        {
            get {
                if(Thread.CurrentThread.CurrentUICulture.Name =="ka-GE")
                {
                    return CaptionKA;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name=="ru-RU")
                {
                    return CaptionRU;
                }
                return CaptionEN;
                }
        }
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
                        CaptionEN = s.CaptionEN,
                        CaptionKA = s.CaptionKA,
                        CaptionRU = s.CaptionRU,
                        PageName=s.PageName,
                        CodeName=s.CodeName,
                        SortVal=s.SortVal,
                        IsVisible=s.IsVisible,
                        PermissionsCode=s.PermissionCode
                    }).ToList();
                }
            });
        }

        public List<Permissions> ListChildPermissions(int? ParentID)
        {
            return TryToReturn(string.Format("Core.UM.PermissionsRepository.ListChildPermissions(ParentID)"), () =>
            {
                using (var db = DB.DBCon.GetUMDataContext())
                {
                    return db.fn_ListChildPermissions(ParentID).Select(s => new Permissions
                    {
                        Level = s.Level,
                        PermissionID = s.PermissionID,
                        CaptionEN = s.CaptionEN,
                        CaptionKA = s.CaptionKA,
                        CaptionRU = s.CaptionRU,
                        PageName = s.PageName,
                        CodeName = s.CodeName,
                        SortVal = s.SortVal,
                        IsVisible = s.IsVisible,
                        PermissionsCode = s.PermissionCode
                    }).ToList();
                }
            });
        }

        public void SP_Permissions(byte? iud, int? PermissionID = null, int? ParentID = null, string CaptionEN = null, string CaptionKA = null, string CaptionRU = null, string PageName = null, string CodeName = null, int? SortVal = null, bool? IsVisible = null)
        {
            TryExecute(string.Format("SP_Permissions(iud = {0}, PermissionID = {1}, ParentID = {2}, CaptionEN = {3}, CaptionKA = {4}, CaptionRU = {5}, PageName = {6}, CodeName = {7}, SortVal = {8}, IsVisible = {9})", iud, PermissionID, ParentID, CaptionEN, CaptionKA, CaptionRU, PageName, CodeName, SortVal, IsVisible)
                , () =>
            {
                using (var db = DB.DBCon.GetUMDataContext())
                {
                    int? NewID = PermissionID;
                    db.sp_Permissions(iud, ref NewID, ParentID, CaptionEN, CaptionKA, CaptionRU, PageName, CodeName, SortVal, IsVisible);
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
                        CaptionEN = s.CaptionEN,
                        CaptionKA = s.CaptionKA,
                        CaptionRU = s.CaptionRU,
                        PageName=s.PageName,
                        CodeName=s.PermissionCode,
                        IsVisible=s.IsVisible
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