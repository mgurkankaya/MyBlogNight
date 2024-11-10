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
    public class TagCloudManager(ITagCloudDal _tagCloudDal) : ITagCloudService
    {
        public void TDelete(int id)
        {
            _tagCloudDal.Delete(id);    
        }

        public List<TagCloud> TGetAll()
        {
            return _tagCloudDal.GetAll();
        }

        public TagCloud TGetById(int id)
        {
            return _tagCloudDal.GetById(id);
        }

        public void TInsert(TagCloud entity)
        {
            _tagCloudDal.Insert(entity);
        }

        public void TUpdate(TagCloud entity)
        {
            _tagCloudDal.Update(entity);
        }
    }
}
