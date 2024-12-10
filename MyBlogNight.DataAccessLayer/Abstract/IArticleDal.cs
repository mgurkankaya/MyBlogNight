using MyBlogNight.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.DataAccessLayer.Abstract
{
    public interface IArticleDal:IGenericDal<Article>
    {
        List<Article> ArticleListWithCategory();
        List<Article> ArticleListWidthCategoryAndAppUser();
        List<Article> GetArticlesByAppUserId(int id);
        Article ArticleListWithCategoryAndAppUserByArticleId(int id);
        void ArticleViewCountIncrease(int id);
        public List<Article> GetTopArticles();
        List<Article> GetArticlesByCategoryId(int categoryId);
        public List<Article> GetLastArticles();
        public List<Article> GetLastArticlesForFeature();
    }
}
