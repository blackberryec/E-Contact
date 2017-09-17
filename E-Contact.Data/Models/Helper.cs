using System;
using System.Collections.Generic;

namespace E_Contact.Data.Models
{
    public partial class Helper
    {
        public int HelpId { get; set; }
        public int? GroupId { get; set; }
        public string Uiculture { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
    }
}
