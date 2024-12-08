using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.DataAccessLayer.Abstract;
using MyBlogNight.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.BusinessLayer.Concrete
{
    public class NewsletterManager(INewsletterDal _newsletterDal) : INewsletterService
    {
        public void TDelete(int id)
        {
            _newsletterDal.Delete(id);
        }

        public List<Newsletter> TGetAll()
        {
            return _newsletterDal.GetAll();
        }

        public Newsletter TGetById(int id)
        {
            return _newsletterDal.GetById(id);
        }

        public void TInsert(Newsletter entity)
        {
            _newsletterDal.Insert(entity);
        }

        public void TUpdate(Newsletter entity)
        {
           _newsletterDal.Update(entity);   
        }
    }
}
