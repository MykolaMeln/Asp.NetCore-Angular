using Project.DAL.EF;
using Project.DAL.Entities;
using Project.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Project.DAL.Repositories
{
    public class UserRepository : GenericRepository<User>
    {
        public UserRepository(DBContext context) : base(context) { }
        public new void Create(User item)
        {
            base.Create(item);
        }
        public new void Delete(int key)
        {
            base.Delete(key);
        }
        public new User Get(int key)
        {
            return base.Get(key);
        }
        public new IEnumerable<User> GetAll()
        {
            return base.GetAll();
        }
        public new void Update(User item)
        {
            base.Update(item);
        }
        public new IEnumerable<User> Find(Func<User, Boolean> predicate)
        {
            return base.Find(predicate);
        }
    }
}
