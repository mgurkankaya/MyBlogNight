﻿using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.DataAccessLayer.Abstract;
using MyBlogNight.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.BusinessLayer.Concrete
{
    public class CommentManager(ICommentDal _commentDal) : ICommentService
    {
        public void TDelete(int id)
        {
            _commentDal.Delete(id);
        }
        public List<Comment> TGetAll()
        {
            return _commentDal.GetAll();    
        }
        public Comment TGetById(int id)
        {
            return _commentDal.GetById(id);
        }
        public void TInsert(Comment entity)
        {
            _commentDal.Insert(entity);
        }
        public void TUpdate(Comment entity)
        {
            _commentDal.Update(entity);
        }
    }
}