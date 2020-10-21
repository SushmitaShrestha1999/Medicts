using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medict.Repository
{
    public interface IRepositoryBase<T>
    {
        T Add(T Entity);
        void Update(T Entity);
        void Delete(T Entity);
        T GetById(int id);
        IEnumerable<T> GetList();


    }
}
