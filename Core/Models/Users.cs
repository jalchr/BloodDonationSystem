using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime Lastlogin { get; set; }
        public string Role { get; set; }
        public string HospitalName { get; set; }
        public string HospitalLocation { get; set; }
        public bool IsAdmin { get; set; }
    }
}
