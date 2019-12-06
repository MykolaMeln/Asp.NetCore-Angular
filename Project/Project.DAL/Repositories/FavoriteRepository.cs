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
    public class FavoriteRepository : GenericRepository<Favorite>
    {
        public FavoriteRepository(DBContext context) : base(context) { }
        public new void Create(Favorite item)
        {
            base.Create(item);
        }
        public new void Delete(int key)
        {
            base.Delete(key);
        }
        public new Favorite Get(int key)
        {
            return base.Get(key);
        }
        public new IEnumerable<Favorite> GetAll()
        {
            return base.GetAll();
        }
        public new void Update(Favorite item)
        {
            base.Update(item);
        }
        public new IEnumerable<Favorite> Find(Func<Favorite, Boolean> predicate)
        {
            return base.Find(predicate);
        }
    }
}
