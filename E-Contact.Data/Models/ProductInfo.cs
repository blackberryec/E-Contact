using System;
using System.Collections.Generic;

namespace E_Contact.Data.Models
{
    public partial class ProductInfo
    {
        public int ProductInfoId { get; set; }
        public int ProductId { get; set; }
        public string Uiculture { get; set; }
        public string ProductName { get; set; }
        public string Summary { get; set; }
        public string OriginalFeature { get; set; }
        public string Packaging { get; set; }
        public string PaymentTerm { get; set; }
        public string Url { get; set; }
        public string Keyword { get; set; }
        public string Description { get; set; }

        public virtual Product Product { get; set; }
    }
}
