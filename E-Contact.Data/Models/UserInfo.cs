using System;
using System.Collections.Generic;

namespace E_Contact.Data.Models
{
    public partial class UserInfo
    {
        public int UserId { get; set; }
        public string Uiculture { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string MobileNumber { get; set; }
        public string Summary { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }

        public virtual UserProfile User { get; set; }
    }
}
