using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemBase;

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
    }
    public class UserRepository : ObjectBase
    {

    }
}
