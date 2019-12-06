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
    public class CommentRepository : GenericRepository<Comment>
    {
        public CommentRepository(DBContext context) : base(context) {}
        public new void Create(Comment item)
        {
            base.Create(item);
        }
        public new void Delete(int key)
        {
            base.Delete(key);
        }
        public new Comment Get(int key)
        {
            return base.Get(key);
        }
        public new IEnumerable<Comment> GetAll()
        {
            return base.GetAll();
        }
        public new void Update(Comment item)
        {
            base.Update(item);
        }
        public new IEnumerable<Comment> Find(Func<Comment, Boolean> predicate)
        {
            return base.Find(predicate);
        }
    }
}
