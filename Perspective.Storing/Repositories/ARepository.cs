using System.Collections.Generic;

namespace Perspective.Storing
{
    public interface ARepository<T>
    {
        T Get(int id);
        T Get(string name);
        List<T> GetAll();
        void Add(T t);
        void Update(T t,string name);
        

        
    }
}