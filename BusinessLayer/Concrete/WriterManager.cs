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
    public class WriterManager : IWriterService
    {
        private readonly IWriterDAL _writerDAL;
        public WriterManager(IWriterDAL writerDAL)
        {
            _writerDAL = writerDAL;
        }
        public async Task AddWriter(Writer writer)
        {
            await _writerDAL.Insert(writer);
        }
    }
}
