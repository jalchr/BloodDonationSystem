using Core.Models;

namespace Web.Models.Mappers
{
   public  interface INewsMapper
   {
       News Map(NewsForm form);
       News Map(int n,NewsForm form);
       
   }
}
