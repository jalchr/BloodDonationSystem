using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class BloodRequestForm
    {
        public int UnitsRequired { get; set; }
        public string BloodType { get; set; }
        public int NumDonator { get; set; }
        public int UserId { get; set; }
    }
}