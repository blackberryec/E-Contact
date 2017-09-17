using System;
using System.Collections.Generic;

namespace E_Contact.Data.Models
{
    public partial class StoreInfo
    {
        public int StoreId { get; set; }
        public string Uiculture { get; set; }
        public string StoreName { get; set; }
        public string Address { get; set; }
        public string Summary { get; set; }
        public string OpenningHours { get; set; }
        public string Keyword { get; set; }
        public string Description { get; set; }

        public virtual Store Store { get; set; }
    }
}
