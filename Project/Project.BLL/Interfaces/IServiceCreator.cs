using Microsoft.EntityFrameworkCore;
using Project.DAL.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.Interfaces
{
    public interface IServiceCreator
    {
      IUserService CreateUserService(DbContextOptions<DBContext> option);
    }
}
