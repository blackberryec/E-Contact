using System;
using System.Collections.Generic;

namespace E_Contact.Data.Models
{
    public partial class District
    {
        public byte DistrictId { get; set; }
        public byte CityId { get; set; }
        public string Name { get; set; }

        public virtual City City { get; set; }
    }
}
