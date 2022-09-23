using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        public async Task Delete(T t)
        {
            using var c = new AppDbContext();
            c.Remove(t);
            await c.SaveChangesAsync();
        }

        public async Task<T> GetById(int id)
        {
            using var c = new AppDbContext();
            return await c.Set<T>().FindAsync(id);

        }

        public List<T> GetListAll()
        {
            using var c = new AppDbContext();
            return c.Set<T>().ToList();
        }

        public async Task Insert(T t)
        {
            using var c = new AppDbContext();
            await c.AddAsync(t);
            await c.SaveChangesAsync();
        }

        public List<T> List(Expression<Func<T, bool>> expression)
        {
            using var c = new AppDbContext();
           return c.Set<T>().Where(expression).ToList(); 
        }

        public async Task Update(T t)
        {
            using var c = new AppDbContext();
            c.Update(t);
            await c.SaveChangesAsync();
        }
    }
}
