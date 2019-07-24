using System;
using System.Collections.Generic;
using AppHotel.Repository.Interface;
using System.Linq;
using AppHotel.Domain.Interface;

namespace AppHotel.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : IEntity
    {



        public delegate void InsertNotify(T t);

        private static List<T> _data;
        private static object _syncObj = new object();

        public Repository()
        {
            if (_data == null)
            {
                lock (_syncObj)
                {
                    if (_data == null)
                    {
                        _data = new List<T>();
                    }
                }
            }
        }
        public T Get(Guid key)
        {
            return _data.Find( x => x.Key == key);
        }


        public List<T> Get()
        {
            return _data;
        }


        public void Insert(T t)
        {
            _data.Add(t);
        }
    }
}
