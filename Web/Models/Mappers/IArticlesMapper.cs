using Core.Models;

namespace Web.Models.Mappers
{
    public interface IArticlesMapper
    {
        Articles Map(ArticlesForm form);
        Articles Map(int n, ArticlesForm form);
    }
}
