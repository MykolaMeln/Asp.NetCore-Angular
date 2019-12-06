using Project.DAL.EF;
using Project.DAL.Entities;
using Project.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Project.DAL.Repositories
{
    public class RadioRepository : GenericRepository<Radio>
    {
        public RadioRepository(DBContext context) : base(context) { }
        public new void Create(Radio item)
        {
            base.Create(item);
        }
        public new void Delete(int key)
        {
            base.Delete(key);
        }
        public new Radio Get(int key)
        {
            return base.Get(key);
        }
        public new IEnumerable<Radio> GetAll()
        {
            return base.GetAll();
        }
        public new void Update(Radio item)
        {
            base.Update(item);
        }
        public new IEnumerable<Radio> Find(Func<Radio, Boolean> predicate)
        {
            return base.Find(predicate);
        }
    }
}
