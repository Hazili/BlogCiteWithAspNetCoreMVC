using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        Task TAdd(T t);
        Task TDelete(T t);
        Task TUpdate(T t);
        List<T> TList();
        Task<T> TGetById(int id);
    }
}
