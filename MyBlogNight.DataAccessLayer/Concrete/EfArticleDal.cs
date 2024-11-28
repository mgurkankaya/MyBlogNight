using Microsoft.EntityFrameworkCore;
using MyBlogNight.DataAccessLayer.Abstract;
using MyBlogNight.DataAccessLayer.Context;
using MyBlogNight.DataAccessLayer.Repositories;
using MyBlogNight.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.DataAccessLayer.Concrete
{
    public class EfArticleDal:GenericRepository<Article>,IArticleDal
    {
        public EfArticleDal(BlogContext context):base(context)
        {
            

        }

        public List<Article> ArticleListWidthCategoryAndAppUser()
        {
            var context = new BlogContext();
            var values = context.Articles.Include(x => x.Category).Include(x => x.AppUser).ToList();
            return values;
        }

        public List<Article> ArticleListWithCategory()
        {
           var context = new BlogContext();
            var value = context.Articles.Include(x => x.Category).ToList();
            return value;
        }

        public Article ArticleListWithCategoryAndAppUserByArticleId(int id)
        {
            var context = new BlogContext();
            var values = context.Articles.Where(x => x.ArticleId == id).Include(y => y.Category).Include(z => z.AppUser).FirstOrDefault();
            return values;
        }

        public void ArticleViewCountIncrease(int id)
        {
            var context = new BlogContext();
            var updatedValue = context.Articles.Find(id);
            updatedValue.ArticleViewCount += 1;
            context.SaveChanges();
        }
    }
}
