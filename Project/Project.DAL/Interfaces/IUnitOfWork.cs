using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Project.DAL.Entities;
using Project.DAL.Identity;

namespace Project.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {

      //  ApplicationUserManager UserManager { get; }
       // ApplicationRoleManager RoleManager { get; }
        Task SaveAsync();
        IRepository<Radio> Radios { get; }
        IRepository<Prohram> Prohrams { get; }
        IRepository<Comment> Comments { get; }
        IRepository<User> Users { get; }
        IRepository<Rating> Ratings { get; }
        IRepository<Favorite> Favorites { get; }
    }
}
