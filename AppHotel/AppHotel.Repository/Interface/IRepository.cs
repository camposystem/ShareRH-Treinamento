

using System;
using System.Collections.Generic;

namespace AppHotel.Repository.Interface
{
    public interface IRepository<T>
    {   /// <summary>
        /// Insere uma classe
        /// </summary>
        /// <param name="t"></param>
        void Insert(T t);
        /// <summary>
        /// Retorna Lista de uma classe
        /// </summary>
        /// <returns></returns>
        List<T> Get();
        T Get(Guid key);
    }


}
