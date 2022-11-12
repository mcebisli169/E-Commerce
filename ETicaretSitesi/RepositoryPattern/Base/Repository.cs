using ETicaretSitesi.Context;
using ETicaretSitesi.Models;
using ETicaretSitesi.RepositoryPattern.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ETicaretSitesi.RepositoryPattern.Base
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        MyDbContext _db;
        DbSet<T> table;
        public Repository(MyDbContext db)
        {
            _db = db;
            table = db.Set<T>();
        }
        private void Save()
        {
            _db.SaveChanges();
        }

        public void Add(T item)
        {
            table.Add(item);
            Save();
        }
        // Any tabloda aranılan kriterde bir değer var mı yok mu onu kontrol eder.varsa true döner.
        public bool Any(Expression<Func<T, bool>> exp)
        {
            return table.Any(exp);
        }
        // Count tablodaki row sayısını dönüyor
        public int Count()
        {
            return table.Count();
        }

        public void Delete(int id)
        {
            T item = GetById(id);
            item.Status = Enums.RecordStatus.Deleted;
            item.ModifiedDate = DateTime.Now;
            table.Update(item);
            Save();
        }

        public IQueryable<T> GetActives()
        {
            return table.Where(x => x.Status != Enums.RecordStatus.Deleted).AsQueryable();
        }

        public IQueryable<T> GetAll()
        {
            return table.AsQueryable();
        }

        public List<T> GetByFilter(Expression<Func<T, bool>> exp)
        {
            return table.Where(exp).ToList();
        }

        public T GetById(int id)
        {
            return table.Find(id);
        }

        public List<T> SelectActivesByLimit(int count)
        {
            return table.Where(x => x.Status != Enums.RecordStatus.Deleted).Take(count).ToList();
        }

        public void Update(T item)
        {
            item.Status = Enums.RecordStatus.Active;
            item.ModifiedDate = DateTime.Now;
            table.Update(item);
            Save();
        }
    }
}
