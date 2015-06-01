using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Core.Models;

namespace Web.Models.Mappers.Imp
{
    public class RegisterMapper: IRegisterMapper
    {

        public Register Map(RegisterForm form)
        {
            var register = new Register();
            register.MName = form.MName;
            register.MBloodType = form.MBloodType;
            register.Date = DateTime.Now;

            return register;
        }


        public Register Map(int n, RegisterForm form)
        {
            var register = new Register();
            register.Id = n;
            register.MName = form.MName;
            register.MBloodType = form.MBloodType;
            register.Date = DateTime.Now;

            return register;
        }
    }
}