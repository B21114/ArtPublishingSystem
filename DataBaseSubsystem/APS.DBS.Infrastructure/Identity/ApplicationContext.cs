using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APS.Dbs.Domain.Entities.Identity;
using APS.DBS.Domain.Entities;
using APS.DBS.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace APS.Web.MVC.DataBaseContext
{
    public class ApplicationContext : IdentityDbContext<User, Role, Guid>
    {
        /// <summary>
        ///  Набор личности.
        /// </summary>
        public DbSet<Person> Persons { get; set; }

        /// <summary>
        ///  Набор контента.
        /// </summary>
        public DbSet<Content> Contents { get; set; }

        /// <summary>
        ///  Набор файлов.
        /// </summary>
        public DbSet<File> Files { get; set; }

        /// <summary>
        ///  Коллекция пользователей.
        /// </summary>
        public override DbSet<User> Users { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        /// <summary>
        ///  Метод для настройки моделей.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);
            modelBuilder.Entity<User>()
                .HasOne(o => o.Person)
                .WithOne();


            modelBuilder.Entity<Person>()
                .HasMany(o => o.ContentList)
                .WithOne();

            modelBuilder.Entity<Content>()
                .HasOne(o => o.File)
                .WithOne();

            /*
            string admin = "Admin";

            string moderator = "Moderator";

            string user = "User";*/
        }
    }
}
