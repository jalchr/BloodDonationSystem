using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;

namespace Infrastructure.Repository
{
    public interface IAddUserRepository
    {
        void InsertUser(Users v);

        Users GetUser(int id);

        void UpdateUser(Users user);

        void DeleteUser(int userId);

        Users[] GetAll();
    }
}
