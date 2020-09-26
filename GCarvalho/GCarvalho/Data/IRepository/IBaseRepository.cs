using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GCarvalho.Data
{
    public interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> Todos();
        void Adicionar(T entity);
        void Excluir(T entity);
        void Alterar(T entity);
        IQueryable<T> Buscar(Expression<Func<T, bool>> expression);
        Task<int> SaveChanges();
    }
}
