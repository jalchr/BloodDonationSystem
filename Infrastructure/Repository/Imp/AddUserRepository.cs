using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using Dapper;

namespace Infrastructure.Repository.Imp
{
    public class AddUserRepository : DbRepository, IAddUserRepository
    {
        public void InsertUser(Users user)
        {
            using (var cnn = OpenConnection())
            {
                var id = cnn.Insert(user);
            }
        }

        public Users GetUser(int id)
        {
            using (var cnn = OpenConnection())
            {
                var user = cnn.Get<Users>(id);
                return user;

            }
        }

        public void UpdateUser(Users user)
        {
            using (var cnn = OpenConnection())
            {
                cnn.Update(user);
            }
        }

        public void DeleteUser(int userId)
        {
            using (var cnn = OpenConnection())
            {
                cnn.Delete<Users>(userId);
            }
        }

        public Users[] GetAll()
        {
            using (var cnn = OpenConnection())
            {
                var users = cnn.GetList<Users>().OrderBy(x => x.Id).ToArray(); ;
                return users;
            }
        }
    }
}
