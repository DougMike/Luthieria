using GCarvalho.Data.Conf;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GCarvalho.Data
{
    public  class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected LuthieriaContext _context { get; set; }

        public BaseRepository(LuthieriaContext context)
        {
            _context = context;
        }
        public void Adicionar(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Excluir(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public IEnumerable<T> Todos()
        {
            return this._context.Set<T>().ToList();
        }

        public void Alterar(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public IQueryable<T> Buscar(Expression<Func<T, bool>> expression)
        {
            return this._context.Set<T>().Where(expression).AsNoTracking();
        }

        public async Task<int> SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
