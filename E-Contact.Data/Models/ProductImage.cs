using System;
using System.Collections.Generic;

namespace E_Contact.Data.Models
{
    public partial class ProductImage
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ImagePath { get; set; }
        public string Summary { get; set; }
        public bool? IsPrimary { get; set; }
    }
}
