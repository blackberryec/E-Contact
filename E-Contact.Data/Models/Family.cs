using System;
using System.Collections.Generic;

namespace E_Contact.Data.Models
{
    public partial class Family
    {
        public Family()
        {
            Category = new HashSet<Category>();
            FamilyInfo = new HashSet<FamilyInfo>();
        }

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
        public string ImageHoverPath { get; set; }

        public virtual ICollection<Category> Category { get; set; }
        public virtual ICollection<FamilyInfo> FamilyInfo { get; set; }
    }
}
