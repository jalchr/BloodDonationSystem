using System;
using Core.Models;

namespace Web.Models.Mappers.Imp
{
   public class ArticlesMapper:IArticlesMapper
    {
        public Articles Map(ArticlesForm form)
        {
            var articles = new Articles();
            articles.Title = form.Title;
            articles.Description = form.Description;
            articles.Date = DateTime.Now;

            return articles;
        }


        public Articles Map(int n, ArticlesForm form)
        {
            var articles = new Articles();
            articles.Id = n;
            articles.Title = form.Title;
            articles.Description = form.Description;
            articles.Date = DateTime.Now;

            return articles;
        }
    }
}
