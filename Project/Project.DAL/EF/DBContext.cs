using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.DAL.Entities;
//using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace Project.DAL.EF
{
      public class DBContext : IdentityDbContext<User>
      {
        public DBContext(DbContextOptions<DBContext> options)
               : base(options)
        { }
        public DBContext()
        {
            Database.EnsureCreated();
        }
        //public DbSet<User> Users { get; set; }
       //public DbSet<Role> Roles { get; set; }
        public DbSet<ClientProfile> ClientProfiles { get; set; }
        public DbSet<Radio> Radio_Stations { get; set; }
        public DbSet<Prohram> Prohrams { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
          /*  string adminRoleName = "admin";
            string userRoleName = "user";

            string adminEmail = "admin@mail.ru";
            string adminPassword = "123456";*/

           /* Role adminRole = new Role { Id = 1, Name = adminRoleName };
            Role userRole = new Role { Id = 2, Name = userRoleName };
            User adminUser = new User { Id = "1", Email = adminEmail, Password = adminPassword, RoleId = adminRole.Id };
            
            builder.Entity<Role>().HasData(new Role[] { adminRole, userRole });
            builder.Entity<User>().HasData(new User[] { adminUser });*/
            base.OnModelCreating(builder);
            builder.Entity<Radio>().HasKey(i => i.RadioId);
            builder.Entity<User>().HasKey(i => i.Id);
            builder.Entity<Rating>().HasKey(i => i.RatingId);
         //   builder.Entity<Rating>().HasAlternateKey(i => i.stationid);
         //    builder.Entity<Rating>().HasAlternateKey(i => i.userid);
            builder.Entity<Prohram>().HasKey(i => i.ProgramId);
         //   builder.Entity<Prohram>().HasAlternateKey(i => i.radioid);
            builder.Entity<Comment>().HasKey(i => i.commentid);
         //  builder.Entity<Comment>().HasAlternateKey(i => i.userid);

            /*builder.Entity<Prohram>()
            .HasOne(p => p.radioid)
            .WithMany(b => b.Prohrams)
            .HasForeignKey(p => p.radioid)
            .HasConstraintName("ForeignKey_Radio_Prohrams");*/

            // builder.Entity<Favorite>().HasAlternateKey(i => i.stationid);
            // builder.Entity<Favorite>().HasAlternateKey(i => i.userid);
            builder.Entity<Favorite>().HasNoKey();

            builder.Entity<User>().Property(a => a.UserName).HasMaxLength(30);
            builder.Entity<Prohram>().Property(a => a.Name_program).HasMaxLength(30);
            builder.Entity<Comment>().Property(a => a.comment).HasMaxLength(200);    
        }

    }
}