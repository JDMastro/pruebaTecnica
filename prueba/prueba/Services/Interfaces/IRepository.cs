using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prueba.Services.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task Add(T entity);
        Task<T> GetById(int id);
        Task<List<T>> Get();
        Task Remove(int id);
        Task Save();
        void Update(T entity);
    }
}
