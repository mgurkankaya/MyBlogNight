using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.BusinessLayer.Abstract
{
    public interface IArticleService : IGenericService<Article>
    {
        List<Article> TArticleListWithCategory();
        List<Article> TArticleListWidthCategoryAndAppUser();
        public Article TArticleListWithCategoryAndAppUserByArticleId(int id);

        public void ArticleViewCountIncrease(int id);
    }
}