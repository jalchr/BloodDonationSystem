using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using Dapper;

namespace Infrastructure.Repository.Imp
{
    public class LoginRepository : DbRepository, ILoginRepository
    {
        public Users Verification(Users user)
        {
            using (var cnn = OpenConnection())
            {
                var query = "select * from Users where Username=@Username and Password =@Password";

                var result = cnn.Query<Users>(query, new { Username = user.UserName, Password = user.Password });

                return result.FirstOrDefault();
            }
        }
    }
}
