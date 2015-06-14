using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Core.Models;

namespace Web.Models.Mappers.Imp
{
    public class AddUserMapper : IAddUserMapper
    {
        public Users Map(CreateUserForm form)
        {
            var user = new Users();
            user.HospitalLocation = form.HospitalLocation;
            user.HospitalName = form.HospitalName;
            user.IsAdmin = form.IsAdmin;
            user.Role = form.Role;
            user.Password = form.Password;
            user.UserName = form.UserName;
            user.Lastlogin = DateTime.Now;
            return user;
        }

        public Users Map(int userId, CreateUserForm form)
        {
            var user = new Users();
            user.Id = userId;
            user.HospitalLocation = form.HospitalLocation;
            user.HospitalName = form.HospitalName;
            user.IsAdmin = form.IsAdmin;
            user.Role = form.Role;
            user.Password = form.Password;
            user.UserName = form.UserName;
            user.Lastlogin = DateTime.Now;
            return user;
        }
    }
}