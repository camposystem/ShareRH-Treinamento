using System;
using System.Collections.Generic;
using System.Text;

namespace WebCarAPI.Repository.Interface
{
    public interface IRepository<T>
    {
        T Get(int id);
        T Get(Guid key);
        List<T> Get();
        List<T> Get(int skip, int take);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
