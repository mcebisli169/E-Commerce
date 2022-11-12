using ETicaretSitesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ETicaretSitesi.RepositoryPattern.Interfaces
{
    public interface IRepository<T> where T :BaseEntity
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetActives();
        T GetById(int id);
        void Add(T item);
        void Update(T item);
        void Delete(int id);
        List<T> GetByFilter(Expression<Func<T, bool>> exp);
        int Count();
        bool Any(Expression<Func<T, bool>> exp);
        List<T> SelectActivesByLimit(int count);
    }
}
