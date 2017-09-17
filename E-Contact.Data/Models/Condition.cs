using System;
using System.Collections.Generic;

namespace E_Contact.Data.Models
{
    public partial class Condition
    {
        public int ConditionId { get; set; }
        public int? CategoryId { get; set; }
        public int? DistrictId { get; set; }
        public int? CityId { get; set; }
        public bool? IsTitle { get; set; }
        public int? IsOffer { get; set; }
        public int? ProductType { get; set; }
        public string SearchText { get; set; }
        public string Tooken { get; set; }
    }
}
