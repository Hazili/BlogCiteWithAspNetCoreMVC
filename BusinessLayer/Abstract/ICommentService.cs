using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void AddComment(Comment comment);
        //Task DeleteComment(Comment comment);
        //Task UpdateComment(Comment comment);
        List<Comment> GetListAll(int id);
        //Task<Comment> GetById(int id);
    }
}
