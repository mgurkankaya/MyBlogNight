using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.BusinessLayer.ErrorMessages;
using MyBlogNight.DataAccessLayer.Abstract;
using MyBlogNight.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.BusinessLayer.Concrete
{
    public class CategoryManager(ICategoryDal _categoryDal) : ICategoryService
    {
        public void TDelete(int id)
        {
            _categoryDal.Delete(id);
        }
        public List<Category> TGetAll()
        {
            return _categoryDal.GetAll();
        }

        public List<int> TGetArticleCount()
        {
            return _categoryDal.GetArticleCount();
        }

        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id);
        }
        public void TInsert(Category entity)
        {
           
                _categoryDal.Insert(entity);
          
        }
        public void TUpdate(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}