
using System;
using System.Collections.Generic;
using WebCarAPI.Domain.Interfce;
using WebCarAPI.Repository.Interface;
using System.Linq;
using Microsoft.Extensions.Logging;
using WebCarAPI.Repository.Utilities;
using System.Data.SqlClient;
using Dapper;
using System.Data;

namespace WebCarAPI.Repository.Base
{
    public class Repository<T>: IRepository<T> where T : IEntity
    {

        private List<T> _data;

        private readonly ILogger<IRepository<T>> _logger;

        protected Repository(ILogger<IRepository<T>> logger)
        {
            _logger = logger;

        }

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

        public T Get(int id)
        {
            return _data.Find(x => x.Id == id);
        }

        public T Get(Guid key)
        {
            return _data.Find(x => x.Key == key);
        }

        public List<T> Get(int skip, int take)
        {
            //todo: Utilizado para paginação.
            return _data.Skip(skip).Take(take).ToList();
        }

        public List<T> Get()
        {
            return _data;
        }

        public void Create(T entity)
        {
            _data.Add(entity);
        }

        public void Update(T entity)
        {
            T oldEntity = Get(entity.Key);
            Delete(oldEntity);
            Create(entity);
        }

        public void Delete(T entity)
        {
            _data.Remove(entity);
        }

        public IEnumerable<T> Query(string query)
        {
            SqlConnection conn = ConnectionFactory.GetConnection();
            try
            {
                var result =  conn.Query<T>(query);
                return result;

            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);

                throw;
            }
            finally
            {

                if ((conn!= null) &&(conn.State != ConnectionState.Closed))
                {
                    conn.Close();
                }

            }
        }
    }
}
