using System;
using System.Collections.Generic;

namespace E_Contact.Data.Models
{
    public partial class CategoryInfo
    {
        public int CategoryInfoId { get; set; }
        public byte CategoryId { get; set; }
        public string Uiculture { get; set; }
        public string CategoryName { get; set; }
        public string Summary { get; set; }
        public string Url { get; set; }
        public string Keyword { get; set; }
        public string Description { get; set; }

        public virtual Category Category { get; set; }
    }
}
