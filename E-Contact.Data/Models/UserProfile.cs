using System;
using System.Collections.Generic;

namespace E_Contact.Data.Models
{
    public partial class UserProfile
    {
        public UserProfile()
        {
            Store = new HashSet<Store>();
            UserInfo = new HashSet<UserInfo>();
            WebpagesUsersInRoles = new HashSet<WebpagesUsersInRoles>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public bool? IsEnterprise { get; set; }
        public byte? Status { get; set; }
        public decimal? CreditLineValue { get; set; }
        public decimal? CreditValue { get; set; }
        public bool? IsPhoneNumberShown { get; set; }
        public string Noted { get; set; }
        public DateTime? EffectedDate { get; set; }
        public DateTime? BlockedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public int? ApprovedBy { get; set; }

        public virtual ICollection<Store> Store { get; set; }
        public virtual ICollection<UserInfo> UserInfo { get; set; }
        public virtual ICollection<WebpagesUsersInRoles> WebpagesUsersInRoles { get; set; }
    }
}
