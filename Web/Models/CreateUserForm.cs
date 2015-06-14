using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class CreateUserForm
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string HospitalName { get; set; }
        public string HospitalLocation { get; set; }
        public bool IsAdmin { get; set; }
    }
}
