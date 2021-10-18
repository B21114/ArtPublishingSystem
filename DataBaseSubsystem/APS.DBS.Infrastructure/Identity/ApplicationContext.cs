using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APS.Dbs.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace APS.Web.MVC.DataBaseContext
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        /// <summary>
        /// Коллекция пользователей.
        /// </summary>
        public override DbSet<User> Users { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }
       
        /// <summary>
        /// Метод для настройки моделей.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string admin = "Admin";

            string moderator = "Moderator";

            string user = "User";
        }
    }
}
