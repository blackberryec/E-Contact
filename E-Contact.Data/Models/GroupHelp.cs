using System;
using System.Collections.Generic;

namespace E_Contact.Data.Models
{
    public partial class GroupHelp
    {
        public int GroupId { get; set; }
        public string UiCulture { get; set; }
        public string GroupName { get; set; }
        public string GroupSummary { get; set; }
        public string GroupUrl { get; set; }
    }
}
