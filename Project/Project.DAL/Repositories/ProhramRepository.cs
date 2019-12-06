using Microsoft.EntityFrameworkCore;
using Project.DAL.EF;
using Project.DAL.Entities;
using Project.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.DAL.Repositories
{
    public class ProhramRepository : GenericRepository<Prohram>
    {
        public ProhramRepository(DBContext context) : base(context) { }
        public new void Create(Prohram item)
        {
            base.Create(item);
        }
        public new void Delete(int key)
        {
            base.Delete(key);
        }
        public new Prohram Get(int key)
        {
            return base.Get(key);
        }
        public new IEnumerable<Prohram> GetAll()
        {
            return base.GetAll();
        }
        public new void Update(Prohram item)
        {
            base.Update(item);
        }
        public new IEnumerable<Prohram> Find(Func<Prohram, Boolean> predicate)
        {
            return base.Find(predicate);
        }
    }
}
