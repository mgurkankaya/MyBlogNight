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
    public class SocialMediaManager(ISocialMediaDal _socialMediaDal) : ISocialMediaService
    {
        public void TDelete(int id)
        {
           _socialMediaDal.Delete(id);
        }

        public List<SocialMedia> TGetAll()
        {
            return _socialMediaDal.GetAll();    
        }

        public SocialMedia TGetById(int id)
        {
            return _socialMediaDal.GetById(id);
        }

        public void TInsert(SocialMedia entity)
        {
            _socialMediaDal.Insert(entity);
        }

        public void TUpdate(SocialMedia entity)
        {
            _socialMediaDal.Update(entity);
        }
    }
}
