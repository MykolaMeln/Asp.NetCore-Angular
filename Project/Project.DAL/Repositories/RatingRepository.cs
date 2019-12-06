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
    public class RatingRepository : GenericRepository<Rating>
    {
        public RatingRepository(DBContext context) : base(context) { }
        public new void Create(Rating item)
        {
            base.Create(item);
        }
        public new void Delete(int key)
        {
            base.Delete(key);
        }
        public new Rating Get(int key)
        {
            return base.Get(key);
        }
        public new IEnumerable<Rating> GetAll()
        {
            return base.GetAll();
        }
        public new void Update(Rating item)
        {
            base.Update(item);
        }
        public new IEnumerable<Rating> Find(Func<Rating, Boolean> predicate)
        {
            return base.Find(predicate);
        }
    }
}
