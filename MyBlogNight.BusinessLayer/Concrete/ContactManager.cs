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
    public class ContactManager(IContactDal _contactDal) : IContactService
    {
        public void TDelete(int id)
        {
            _contactDal.Delete(id); 
        }

        public List<Contact> TGetAll()
        {
            return _contactDal.GetAll();
        }

        public Contact TGetById(int id)
        {
            return _contactDal.GetById(id);
        }

        public void TInsert(Contact entity)
        {
            _contactDal.Insert(entity);
        }

        public void TUpdate(Contact entity)
        {
            _contactDal.Update(entity);
        }
    }
}
