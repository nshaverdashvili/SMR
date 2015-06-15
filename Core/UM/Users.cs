using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using SystemBase;
using Lib;

namespace Core.UM 
{
    public class Users
    {
        public long? UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public bool? Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public int? CountryID { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Avatar { get; set; }
        public string About { get; set; }
        public bool? IsActive { get; set; }
        public List<Permissions> Permissions { get; set; }
        public List<Roles> Roles { get; set; }
        public bool IsAuth { get; set; }
        public bool IsAdmin { get; set; }
    }

    public class UserRepository : ObjectBase
    {

        public static Users UserObject {
            get
            {
                return HttpContext.Current.Session["UserObj"] as Users;
            }

            set
            {
                HttpContext.Current.Session["UserObj"] = value;
            }
        }

        public long? ID { get; set; }

        public static bool Authenticate(string UserName, string Password) {
                using (var db = DB.DBCon.GetUMDataContext())
                {
                  UserObject = db.fn_Authenticate(UserName, Password).DeserializeTo<Users>();
                    if (UserObject!=null)
	                {
                        UserObject.IsAuth=true;
                        UserObject.IsAdmin = UserObject.UserName=="admin";
		                return true;
	                }
                }
            return false;
        }

        public static bool IsAuthenticated(){ 
            return HttpContext.Current.Session["UserObj"] != null;
        }
        public List<Users> ListUsers()
        {
            return TryToReturn(string.Format("Core.UM.UserRepository.ListUsers()"),()=>
                {
                    using(var db = DB.DBCon.GetUMDataContext())
                    {
                        return  db.fn_List_Users().Select(s => new Users
                            {	
                                UserID=s.UserID,	
                                UserName=s.Username,
                                Password=s.Password,
                                Fname=s.Fname,
                                Lname=s.Lname,
                                Email=s.Email,
                                Gender=s.Gender,	
                                BirthDate=s.BirthDate,
                                Phone=s.Phone,	
                                Mobile=s.Mobile,
                                Address=s.Address,
                                CountryID=s.CountryID,
                                Zip=s.Zip,
                                City=s.City,	
                                Avatar=s.Avatar,	
                                About=s.About,		
                                IsActive=s.IsActive	
                            }).ToList();
                    }
                });
        }
        
        public void SP_Users(byte? iud, long? UserID = null, string Username = null, string Password = null, string Fname = null, string Lname = null, 
                             string Email = null, bool? Gender = null, DateTime? BirthDate = null, string Phone = null, string Mobile = null, string Address = null, 
                             int? CountryID = null, string Zip = null, string City = null, string Avatar = null, string About = null, bool? IsActive = null)
        {
            TryExecute(string.Format(@"Core.UM.UserRepository(iud = {0}, UserID = {1}, Username = {2}, Password = {3},	 Fname = {4}
            Lname = {5}, Email = {6}, Gender = {7}, BirthDate = {8}, Phone	 = {9}, Mobile = {10},
            Address = {11}, CountryID = {12}, Zip = {13}, City = {14}, Avatar = {15}, About = {16},
            IsActive = {17})", iud, UserID ,Username, Password, Fname, Lname, Email, Gender, BirthDate, Phone, Mobile, Address, CountryID, Zip,City, Avatar, About, IsActive), () => 
            {
                using (var db = DB.DBCon.GetUMDataContext())
                {
                    long? NewID = UserID;
                    db.sp_Users(iud, ref NewID, Username, Password==null ? null : Password.MD5(), Fname, Lname, Email, Gender, BirthDate, Phone, Mobile, Address, CountryID, Zip,
                        City, Avatar, About, IsActive);
                    this.ID = NewID;
                }
            });
        }
    
    
    }

    
}
