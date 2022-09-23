using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDAL
    {
        public async Task<List<Blog>> GetListWithCategory()
        {
            using (var appDbContext = new AppDbContext())
            {
                return appDbContext.Blogs.Include(x => x.Category).ToList();
            }
        }

        public async Task<List<Blog>> GetListWithCategoryByWriter(int id)
        {
             using (var appDbContext = new AppDbContext())
            {
                return appDbContext.Blogs.Include(x => x.Category).Where(x=>x.WriterId == id).ToList();
            }
        }
    }
}
