using System;
using System.Collections.Generic;

namespace E_Contact.Data.Models
{
    public partial class Category
    {
        public Category()
        {
            CategoryInfo = new HashSet<CategoryInfo>();
        }

        public byte CategoryId { get; set; }
        public byte FamilyId { get; set; }
        public string ImagePath { get; set; }
        public byte? Sequence { get; set; }
        public int? State { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public int? ApprovedBy { get; set; }

        public virtual ICollection<CategoryInfo> CategoryInfo { get; set; }
        public virtual Family Family { get; set; }
    }
}
