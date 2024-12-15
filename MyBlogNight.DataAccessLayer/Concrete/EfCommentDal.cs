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
    public class EfCommentDal:GenericRepository<Comment>,ICommentDal
    {
        public EfCommentDal(BlogContext context):base(context) { }

        public List<Comment> GetCommentsByAppUserId(int id)
        {
            var context = new BlogContext();
            var value = context.Comments.Where(x => x.AppUserId == id).Include(y => y.Article).ThenInclude(x => x.AppUser).ToList();
            return value;
        }

        public List<Comment> GetCommentsByArticleId(int id)
        {
            var context = new BlogContext();
            var value = context.Comments
        .Include(c => c.AppUser) // Kullanıcı bilgilerini dahil et
        .Where(c => c.ArticleId == id) // Yalnızca ilgili makaleye ait yorumlar
        .ToList();
            return value;
        }
    }
}