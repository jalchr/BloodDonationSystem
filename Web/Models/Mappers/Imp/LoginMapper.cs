using System;
using Core.Models;

namespace Web.Models.Mappers.Imp
{
    public class LoginMapper:ILoginMapper
    {
        public Users Map(Loginform form)
        {
            var us=new Users();
            us.Id = 0;
            us.Username = form.Username;
            us.Password = form.Password;
            us.Lastlogin=DateTime.Now;
            return us;
        }
    }
}