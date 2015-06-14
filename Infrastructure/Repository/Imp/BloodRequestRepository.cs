using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using Dapper;

namespace Infrastructure.Repository.Imp
{
   public class BloodRequestRepository: DbRepository, IBloodRequestRepository

    {
       public void InsertBloodRequest(BloodRequest bloodRequest)
       {
           using (var cnn = OpenConnection())
           {
               var id = cnn.Insert(bloodRequest);
           
           }
       }

       public BloodRequest[] GetRequestByUserId(int userId)
       {

           using (var cnn = OpenConnection())
           {
              var tab = cnn.GetList<BloodRequest>().Where(x=>x.UserId == userId).OrderByDescending(x => x.Date).ToArray(); ;
               return tab;
           }
       }

       public void DeleteBloodRequest(int val)
       {
           using (var cnn = OpenConnection())
           {
               cnn.Delete<BloodRequest>(val);
           }
       }

       public void UpdateBloodRequest(BloodRequest bloodRequest)
       {
           using (var cnn = OpenConnection())
           {
               cnn.Update(bloodRequest);
           }
       }

       public BloodRequest GetBloodRequest(int id)
       {
           using (var cnn = OpenConnection())
           {
               var tab = cnn.Get<BloodRequest>(id);
               return tab;

           }
       }


       public BloodRequest[] Selectpage(int id, out int total)
       {
           using (var cnn = OpenConnection())
           {
               var tab = cnn.GetList<BloodRequest>().OrderByDescending(x => x.Date).ToArray();
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
