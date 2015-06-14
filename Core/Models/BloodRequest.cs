using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class BloodRequest
    {
        [Key]
        public int Id { set; get; }
        public string BloodType { set; get; }
        public int UnitsRequired { set; get; }
        public int NumOffered { set; get; }
        public int NumDonator { set; get; }
        public DateTime Date { set; get; }
        public int UserId { get; set; }

    }
}
