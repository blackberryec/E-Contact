using System;
using System.Collections.Generic;

namespace E_Contact.Data.Models
{
    public partial class WebpagesUsersInRoles
    {
        public int RoleId { get; set; }
        public int UserId { get; set; }

        public virtual WebpagesRoles Role { get; set; }
        public virtual UserProfile User { get; set; }
    }
}
