using System;
using System.Collections.Generic;

namespace E_Contact.Data.Models
{
    public partial class WebpagesOauthMembership
    {
        public string Provider { get; set; }
        public string ProviderUserId { get; set; }
        public int UserId { get; set; }
    }
}
