﻿using Ninject.Modules;
using Project.DAL.Interfaces;
using Project.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.Infrastructure
{ 
    public class ServiceModule : NinjectModule
    {
        private string connectionString;
        public ServiceModule(string connection)
        {
            connectionString = connection;
        }
        public override void Load()
        {
            Bind<IUnitOfWork>().To<EFUnitOfWork>().WithConstructorArgument(connectionString);
        }
    }
}
