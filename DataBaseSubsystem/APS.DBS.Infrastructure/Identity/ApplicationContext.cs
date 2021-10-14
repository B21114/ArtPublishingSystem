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
        public ApplicationContext(DbContextOptions options): base(options)
        {
            
        }
    }
}
