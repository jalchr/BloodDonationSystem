using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using Dapper;

namespace Infrastructure.Repository.Imp
{
    public class RegisterRepository : DbRepository, IRegisterRepository
    {
        public void InsertRegister(Register register)
        {
            using (var cnn = OpenConnection())
            {
                var id = cnn.Insert(register);
            }
        }

        
        public Register[] SelectAllRegisters()
        {

            using (var cnn = OpenConnection())
            {
                Register[] tab = cnn.GetList<Register>().OrderByDescending(x => x.Date).ToArray(); ;
                return tab;
            }
        }

        public void DeleteRegister(int val)
        {
            using (var cnn = OpenConnection())
            {
                cnn.Delete<Register>(val);
            }
        }

        public void UpdateRegister(Register register)
        {
            using (var cnn = OpenConnection())
            {
                cnn.Update(register);
            }
        }

        public Register GetRegister(int id)
        {
            using (var cnn = OpenConnection())
            {
                var tab = cnn.Get<Register>(id);
                return tab;

            }
        }


        public Register[] Selectpage(int id, out int total)
        {
            using (var cnn = OpenConnection())
            {
                var tab = cnn.GetList<Register>().OrderByDescending(x => x.Date).ToArray();
                var totalcount = tab.Count();
                var currentpage = id;
                const int pagesize = 3;
                total = (int)Math.Ceiling((double)totalcount / pagesize);
                var pagetab = tab.Skip((currentpage - 1) * pagesize)
                                    .Take(pagesize)
                                    .ToArray();
                return pagetab;

            }
        }



    }



}


