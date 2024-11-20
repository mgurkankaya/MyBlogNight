﻿using Microsoft.EntityFrameworkCore;
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

        public List<Article> ArticleListWithCategory()
        {
           var context = new BlogContext();
            var value = context.Articles.Include(x => x.Category).ToList();
            return value;
        }
    }
}
