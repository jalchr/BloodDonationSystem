using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;

namespace Infrastructure.Repository
{
    public interface IBloodRequestRepository
    {
        void InsertBloodRequest (BloodRequest v);

        BloodRequest[] GetRequestByUserId(int userId);

        void UpdateBloodRequest(BloodRequest v);

        void DeleteBloodRequest (int v);
        BloodRequest GetBloodRequest(int id);
        BloodRequest[] Selectpage(int id, out int total);
    }
}
