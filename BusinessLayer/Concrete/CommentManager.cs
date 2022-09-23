using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentDAL _commentDAL;
        public CommentManager(ICommentDAL commentDAL)
        {
            _commentDAL = commentDAL;
        }
        public void AddComment(Comment comment)
        {
            _commentDAL.Insert(comment);
        }

        public List<Comment> GetListAll(int id)
        {
            return  _commentDAL.List(x => x.BlogId == id);
        }
    }
}
