using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;

namespace Web.Models.Mappers
{
   public interface IBloodRequestMapper
    {
        BloodRequest Map(BloodRequestForm form);
        BloodRequest Map(int n, BloodRequestForm form, string s);
    }
}
