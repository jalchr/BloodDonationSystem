using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;

namespace Web.Models.Mappers
{
    public interface IRegisterMapper
    {
        Register Map(RegisterForm form);
        Register Map(int n, RegisterForm form);
    }
}
