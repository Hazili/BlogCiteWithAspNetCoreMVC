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
    public class AboutManager : IAboutService
    {
        private readonly IAboutDAL _aboutDAL;
        public AboutManager(IAboutDAL aboutDAL)
        {
            _aboutDAL = aboutDAL;
        }
        public Task TAdd(About t)
        {
            throw new NotImplementedException();
        }

        public Task TDelete(About t)
        {
            throw new NotImplementedException();
        }

        public Task<About> TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> TList()
        {
            return _aboutDAL.GetListAll();
        }

        public Task TUpdate(About t)
        {
            throw new NotImplementedException();
        }
    }
}
