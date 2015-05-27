using Core.Models;

namespace Web.Models.Mappers
{
    interface ILoginMapper
    {
       Users Map(Loginform form);
    }
}
