using System;
using System.Collections.Generic;

namespace E_Contact.Data.Models
{
    public partial class City
    {
        public City()
        {
            District = new HashSet<District>();
        }

        public byte CityId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<District> District { get; set; }
    }
}
