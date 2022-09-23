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
    public class ContactManager : IContactService
    {
        private readonly IContactsDAL _contactDAL;
        public ContactManager(IContactsDAL contactDAL)
        {
            _contactDAL = contactDAL;
        }
        public async Task ContactAdd(Contact contact)
        {
            await _contactDAL.Insert(contact);
        }
    }
}
