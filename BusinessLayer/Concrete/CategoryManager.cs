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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDAL _categoryDAL;
        public CategoryManager(ICategoryDAL

            categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public async Task TAdd(Category t)
        {
            await _categoryDAL.Insert(t);
        }

        public async Task TDelete(Category t)
        {
            await _categoryDAL.Delete(t);
        }

        public async Task<Category> TGetById(int id)
        {
            return await _categoryDAL.GetById(id);
        }

        public List<Category> TList()
        {
            return _categoryDAL.GetListAll();
        }

        public async Task TUpdate(Category t)
        {
            await _categoryDAL.Update(t);
        }
    }
}
