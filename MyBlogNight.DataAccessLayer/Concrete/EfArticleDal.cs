using Microsoft.EntityFrameworkCore;
using MyBlogNight.DataAccessLayer.Abstract;
using MyBlogNight.DataAccessLayer.Context;
using MyBlogNight.DataAccessLayer.Repositories;
using MyBlogNight.DtoLayer;
using MyBlogNight.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.DataAccessLayer.Concrete
{
    public class EfArticleDal : GenericRepository<Article>, IArticleDal
    {
        public EfArticleDal(BlogContext context) : base(context)
        {


        }

        public List<Article> ArticleListWidthCategoryAndAppUser()
        {
            var context = new BlogContext();
            var values = context.Articles.Include(x => x.Category).Include(x => x.AppUser).OrderByDescending(x => x.CreatedDate).ToList();
            return values;
        }

        public List<Article> ArticleListWithCategory()
        {
            var context = new BlogContext();
            var value = context.Articles.Include(x => x.Category).OrderByDescending(x => x.CreatedDate).ToList();
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

        public List<Article> GetArticlesByAppUserId(int id)
        {
            var context = new BlogContext();
            var values = context.Articles.Where(x => x.AppUserId == id).ToList();
            return values;
        }

        public List<Article> GetTopArticles()
        {

            var context = new BlogContext();
                var value = context.Articles.OrderByDescending(x => x.ArticleViewCount).Take(3).ToList();
                return value;
  
        }

        public List<Article> GetLastArticlesForFeature()
        {

            var context = new BlogContext();
            var value = context.Articles.OrderByDescending(x => x.CreatedDate).Take(1).ToList();
            return value;

        }

        public List<Article> GetLastArticles()
        {

            var context = new BlogContext();
            var value = context.Articles.OrderByDescending(x=>x.CreatedDate).Take(3).ToList();
            return value;

        }

        public List<Article> GetArticlesByCategoryId(int categoryId)
        {
            using (var context = new BlogContext())
            {
                return context.Articles
                    .Where(a => a.CategoryId == categoryId)
                    .Include(a => a.Category) 
                    .OrderByDescending(a => a.ArticleViewCount)
                    .ToList();
            }
        }

        public IEnumerable<CategoryArticleCountDto> GetArticleCountByCategory()
        {
            var context = new BlogContext();
            var value = context.Articles
        .GroupBy(a => a.Category.CategoryName)
        .Select(g => new CategoryArticleCountDto
        {
            CategoryName = g.Key,
            ArticleCount = g.Count()
        })
        .ToList();

            return value;
        }
    }
}