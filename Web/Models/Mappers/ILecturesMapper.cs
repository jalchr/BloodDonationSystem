using Core.Models;

namespace Web.Models.Mappers
{
   public interface ILecturesMapper
    {
       //Lectures Map(LecturesForm form);
       Lectures Map( LecturesForm form);
       Lectures Map(int n, LecturesForm form,string s);
    }
}
