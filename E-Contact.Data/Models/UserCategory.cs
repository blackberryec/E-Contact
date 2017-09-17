using System;
using System.Collections.Generic;

namespace E_Contact.Data.Models
{
    public partial class UserCategory
    {
        public byte CategoryId { get; set; }
        public int UserId { get; set; }
        public DateTime? JoinedDate { get; set; }
    }
}
