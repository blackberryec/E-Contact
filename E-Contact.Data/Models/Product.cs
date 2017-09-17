using System;
using System.Collections.Generic;

namespace E_Contact.Data.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductInfo = new HashSet<ProductInfo>();
        }

        public int ProductId { get; set; }
        public byte FamilyId { get; set; }
        public int UserId { get; set; }
        public int StoreId { get; set; }
        public byte DistrictId { get; set; }
        public byte CityId { get; set; }
        public int? ProductType { get; set; }
        public decimal? Price { get; set; }
        public decimal? Fobprice { get; set; }
        public decimal? Weight { get; set; }
        public byte? Sequence { get; set; }
        public string PhoneContact { get; set; }
        public string EmailContact { get; set; }
        public string ImagePath { get; set; }
        public int? ViewCount { get; set; }
        public bool? IsVip { get; set; }
        public bool? IsOffer { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public int? ApprovedBy { get; set; }
        public int? TotalView { get; set; }
        public bool? IsPublicPhone { get; set; }
        public int? CategoryId { get; set; }

        public virtual ICollection<ProductInfo> ProductInfo { get; set; }
    }
}
