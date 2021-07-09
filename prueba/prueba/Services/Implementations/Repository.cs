using Microsoft.EntityFrameworkCore;
using prueba.Data;
using prueba.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prueba.Services.Implementations
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly AppDbContext Context;

        public Repository(AppDbContext ctx) => Context = ctx;

        public async Task Add(T entity) => await Context.Set<T>().AddAsync(entity);


        public async Task<List<T>> Get() => await Context.Set<T>().ToListAsync();

        public async Task<T> GetById(int id) => await Context.Set<T>().FindAsync(id);

        public async Task Remove(int id)
        {
            var type = await Context.Set<T>().FindAsync(id);
            Context.Remove(type);
        }

        public async Task Save() => await Context.SaveChangesAsync();

        public void Update(T entity) => Context.Entry(entity).State = EntityState.Modified;

    }
}
