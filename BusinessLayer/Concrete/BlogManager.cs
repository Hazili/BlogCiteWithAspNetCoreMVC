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
    public class BlogManager : IBlogService
    {
        private readonly IBlogDAL _blogDAL;

        public BlogManager(IBlogDAL blogDAL)
        {
            _blogDAL = blogDAL;
        }
        //public async Task AddBlog(Blog blog)
        //{
        //    await _blogDAL.Insert(blog);
        //}

        public async Task DeleteBlog(Blog blog)
        {
            await _blogDAL.Delete(blog);
        }

        public async Task<Blog> GetById(int id)
        {

            return await _blogDAL.GetById(id);
        }

        //bu method interfacede yazilmayib!
        public List<Blog> GetBlogById(int id)
        {
            return _blogDAL.List(x => x.BlogId == id);
        }

        public async Task<List<Blog>> GetListWithCategoryByWriter(int id)
        {
            return await _blogDAL.GetListWithCategoryByWriter(id);
        }

        public List<Blog> GetListAll()
        {
            var blogs = _blogDAL.GetListAll();
            return blogs;
        }

        public List<Blog> GetLast3Posts()
        {
            return _blogDAL.GetListAll().Take(3).ToList();
        }

        public async Task<List<Blog>> GetListBlogWithCategory()
        {
            return await _blogDAL.GetListWithCategory();
        }

        public async Task UpdateBlog(Blog blog)
        {
            await _blogDAL.Update(blog);
        }

        public List<Blog> GetListBlogByWriter(int id)
        {
            return _blogDAL.List(x => x.WriterId == id);
        }

        public async Task TAdd(Blog t)
        {
            await _blogDAL.Insert(t);
        }

        public async Task TDelete(Blog t)
        {
           await _blogDAL.Delete(t);
        }

        public Task TUpdate(Blog t)
        {
            throw new NotImplementedException();
        }

        public List<Blog> TList()
        {
            throw new NotImplementedException();
        }

        public Task<Blog> TGetById(int id)
        {
            return _blogDAL.GetById(id);
        }
    }
}
