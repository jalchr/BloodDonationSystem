using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;

namespace Infrastructure.Repository
{
    public interface IRegisterRepository
    {
        void InsertRegister(Register v);

        Register[] SelectAllRegisters();

        void UpdateRegister(Register v);

        void DeleteRegister(int v);
        Register GetRegister(int id);
        Register[] Selectpage(int id, out int total);
    }
}
