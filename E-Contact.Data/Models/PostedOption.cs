using System;
using System.Collections.Generic;

namespace E_Contact.Data.Models
{
    public partial class PostedOption
    {
        public string CategoryOptionId { get; set; }
        public byte CategoryId { get; set; }
        public int CategoryInfoId { get; set; }
        public string Uiculture { get; set; }
        public string ParameterGroup { get; set; }
        public string ParameterKeyTo { get; set; }
        public string ParameterValueTo { get; set; }
        public string ParameterKeyFrom { get; set; }
        public string ParameterValueFrom { get; set; }
        public string ParameterValueDefault { get; set; }
        public string ParameterType { get; set; }
    }
}
