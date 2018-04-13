using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core
{
    public interface IRepository<T>
    {
        void Create(T Obj);
        T Read(String Id);
        IEnumerable<T> ReadAll();
        void Update(T Obj);
        void Delete(String Id);
    }
}
