﻿using Microsoft.EntityFrameworkCore;
using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.DataAccessLayer.Abstract;
using MyBlogNight.DtoLayer;
using MyBlogNight.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.BusinessLayer.Concrete
{
    public class ArticleManager(IArticleDal _articleDal) : IArticleService
    {
        public void ArticleViewCountIncrease(int id)
        {
            _articleDal.ArticleViewCountIncrease(id);
        }

        public List<Article> TArticleListWidthCategoryAndAppUser()
        {
            return _articleDal.ArticleListWidthCategoryAndAppUser();
        }

        public List<Article> TArticleListWithCategory()
        {
            return _articleDal.ArticleListWithCategory();
        }

        public Article TArticleListWithCategoryAndAppUserByArticleId(int id)
        {
            return _articleDal.ArticleListWithCategoryAndAppUserByArticleId(id);

        }

        public void TDelete(int id)
        {
            _articleDal.Delete(id);
        }

        public List<Article> TGetAll()
        {
            return _articleDal.GetAll();
        }

        public List<Article> TGetArticlesByAppUserId(int id)
        {
            return _articleDal.GetArticlesByAppUserId(id);
        }

        public Article TGetById(int id)
        {
            return _articleDal.GetById(id);
        }

        public List<Article> TGetTopArticles()
        {
            return _articleDal.GetTopArticles();
        }

        public void TInsert(Article entity)
        {
            _articleDal.Insert(entity);
        }

        public void TUpdate(Article entity)
        {
            _articleDal.Update(entity);
        }
        public List<Article> TGetArticlesByCategoryId(int categoryId)
        {
            return _articleDal.GetArticlesByCategoryId(categoryId);
        }

        public List<Article> TGetLastArticles()
        {
            return _articleDal.GetLastArticles();
        }

        public List<Article> TGetLastArticlesForFeature()
        {
           return _articleDal.GetLastArticlesForFeature();
        }

        public IEnumerable<CategoryArticleCountDto> TGetArticleCountByCategory()
        {
            return _articleDal.GetArticleCountByCategory();
        }
    }
}