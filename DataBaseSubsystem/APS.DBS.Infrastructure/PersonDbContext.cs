using APS.DBS.Domain;
using APS.DBS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.DBS.Infrastructure
{
    /// <summary>
    /// Контекст базы данных личности.
    /// </summary>
    public class PersonDbContext : DbContext, IPersonDbContext
    {
        /// <inheritdoc>
        public DbSet<Person> Persons { get; set; }

        public PersonDbContext(DbContextOptions<PersonDbContext> options) : base(options)
        {

        }

    }
}
