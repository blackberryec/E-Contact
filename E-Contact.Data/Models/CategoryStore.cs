using System;
using System.Collections.Generic;

namespace E_Contact.Data.Models
{
    public partial class CategoryStore
    {
        public byte CategoryId { get; set; }
        public int StoreId { get; set; }
        public int UserId { get; set; }
        public DateTime? JoinedDate { get; set; }
    }
}
