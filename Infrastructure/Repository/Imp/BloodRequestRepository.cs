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

       public BloodRequest[] GetAllRequests()
       {

           var query =
               "Select  b.Id as BID,b.UserID as UserId,b.BloodType as BloodType,b.Date as Date,b.UnitsRequired as UnitsRequired ,b.NumOffered as NumOffered,b.NumDonator as NumDonator , u.HospitalName from BloodRequest b inner join Users u on u.Id = b.UserId Order By Date Desc ";

           using (var cnn = OpenConnection())
           {
               return cnn.Query(query).Select(x => new BloodRequest()
               {
                   UserId = x.UserId,
                   Date = x.Date,
                   Id = x.BID,
                   BloodType = x.BloodType,
                   NumOffered = x.NumOffered,
                   NumDonator = x.NumDonator,
                   HospitalName = x.HospitalName,
                   UnitsRequired = x.UnitsRequired

               }).ToArray();
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
