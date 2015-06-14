using System;
using Core.Models;

namespace Web.Models.Mappers.Imp
{
    public class LoginMapper:ILoginMapper
    {
        public Users Map(Loginform form)
        {
            var user=new Users();
            user.Id = 0;
            user.UserName = form.Username;
            user.Password = form.Password;
            user.Lastlogin = DateTime.Now;
            return user;
        }
    }
}