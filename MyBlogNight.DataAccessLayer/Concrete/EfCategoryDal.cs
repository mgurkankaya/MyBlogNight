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
    public class EfCategoryDal:GenericRepository<Category>,ICategoryDal
    {
        public EfCategoryDal(BlogContext context):base(context) { }

        public List<int> GetArticleCount()
        {
            var context = new BlogContext();
            var result = context.Categories.Select(c => context.Articles.Count(a => a.CategoryId == c.CategoryId))
            .ToList();
            return result;
        }
    }
}
