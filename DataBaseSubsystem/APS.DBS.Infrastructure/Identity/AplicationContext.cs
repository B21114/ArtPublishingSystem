using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APS.Dbs.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace APS.Web.MVC.DataBaseContext
{
    public class AplicationContext : IdentityDbContext<User>
    {
        public AplicationContext(DbContextOptions options): base(options)
        {
            
        }
    }
}
