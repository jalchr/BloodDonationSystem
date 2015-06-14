using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Register
    {
        [Key]

        public int Id { set; get; }

        public string MBloodType { set; get; }

        public string PhoneNum { set; get; }

        public string MName { set; get; }

        public DateTime Date { set; get; }
    }
}
