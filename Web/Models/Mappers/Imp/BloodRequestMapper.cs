using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Core.Models;

namespace Web.Models.Mappers.Imp
{
    public class BloodRequestMapper
    {

        public BloodRequest Map(BloodRequestForm form)
        {
            var newRequest = new BloodRequest();
            newRequest.UnitsRequired = form.UnitsRequired;
            newRequest.BloodType = form.BloodType;
            newRequest.Date = DateTime.Now;
            newRequest.UserId = form.UserId;

            return newRequest;
        }


        public BloodRequest Map(int n, BloodRequestForm form)
        {
            var newRequest = new BloodRequest();
            newRequest.Id = n;
            newRequest.UnitsRequired = form.UnitsRequired;
            newRequest.BloodType = form.BloodType;
            newRequest.Date = DateTime.Now;
            newRequest.UserId = form.UserId;
            newRequest.NumDonator = form.NumDonator;
            return newRequest;
        }
    }
}