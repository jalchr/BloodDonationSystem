using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;

namespace Web.Models.Mappers
{
    public  interface IAddUserMapper
    {
        Users Map(CreateUserForm form);
        Users Map(int userId, CreateUserForm form);
    }
}
