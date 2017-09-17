using System;
using System.Collections.Generic;

namespace E_Contact.Data.Models
{
    public partial class Store
    {
        public Store()
        {
            StoreInfo = new HashSet<StoreInfo>();
        }

        public int StoreId { get; set; }
        public int UserId { get; set; }
        public byte DistrictId { get; set; }
        public byte CityId { get; set; }
        public string TaxCode { get; set; }
        public string Url { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string MobileNumber { get; set; }
        public byte? Sequence { get; set; }
        public string ImagePath { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public int? ApprovedBy { get; set; }

        public virtual ICollection<StoreInfo> StoreInfo { get; set; }
        public virtual UserProfile User { get; set; }
    }
}
