using System;
using System.Collections.Generic;

namespace E_Contact.Data.Models
{
    public partial class FamilyInfo
    {
        public byte FamilyId { get; set; }
        public string Uiculture { get; set; }
        public string FamilyName { get; set; }
        public string Summary { get; set; }
        public string Url { get; set; }
        public string Keyword { get; set; }
        public string Description { get; set; }

        public virtual Family Family { get; set; }
    }
}
