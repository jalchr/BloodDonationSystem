using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class RegisterForm
    {
        public RegisterForm()
        {
            Id = 1;
            Date = DateTime.Now;
        }
        public string MName { get; set; }
        public string MBloodType { get; set; }
        public string PhoneNum { get; set; }
        public int Id { get; set; }
        public DateTime Date { get; set; }
    }
}