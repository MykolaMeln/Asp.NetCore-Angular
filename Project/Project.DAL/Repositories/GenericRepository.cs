using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Project.DAL.EF;
using Project.DAL.Interfaces;

namespace Project.DAL.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class //where DC : DbContext, new()
    {
   
        public DBContext DC;
        public DbSet<T> _dbSet;

        public GenericRepository(DBContext context)
        {
            DC = context;
            _dbSet = context.Set<T>();
        }
        public void Create(T item)
        {
            _dbSet.Add(item);
            DC.SaveChanges();
        }
        public void Delete(int key)
        {
            using (DC)
            {
                T c = DC.Set<T>().Find(Convert.ToInt32(key));
                DC.Set<T>().Remove(c);
            }
        }
        public T Get(int key)
        {
                return _dbSet.Find(Convert.ToInt32(key));
        }
        public IEnumerable<T> GetAll()
        {
            using (DC)
            {
                return _dbSet.AsNoTracking().ToList();
            }
        }
        public void Update(T item)
        {
            DC.Entry(item).State = EntityState.Modified;
            DC.SaveChanges();
        }
        public IEnumerable<T> Find(Func<T, Boolean> predicate)
        {
            return _dbSet.Where(predicate).ToList();
        }

        T IRepository<T>.Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
