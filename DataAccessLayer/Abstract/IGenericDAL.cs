using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDAL<T> where T : class
    {
        Task Insert(T t);
        Task Delete(T t);
        Task Update(T t);
        List<T> GetListAll();
        Task<T> GetById(int id);
        List<T> List(Expression<Func<T, bool>> expression); 
    }
}
